using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;

namespace OctaneApp
{
    public class cDAL
    {
        public string ErrorQuery = string.Empty;
        public bool IsTransactionalError = false;

        private SqlTransaction _transaction;
        private SqlConnection _connection;
        private SqlCommand _command;
        private string connectionString = string.Empty;

        public cDAL(bool has_Transactional_Queries, string otherCS = null)
        {
            if (HttpContext.Current.Session["CSType"] == null)
                return;


            if (otherCS == null || otherCS == string.Empty)
            {
                string csType = HttpContext.Current.Session["CSType"].ToString();
                if (csType == "Live")
                    connectionString = ConfigurationManager.ConnectionStrings["OctaneLive"].ConnectionString;
                else if (csType == "Demo")
                    connectionString = ConfigurationManager.ConnectionStrings["OctaneDemo"].ConnectionString;
                else if (csType == "Train")
                    connectionString = ConfigurationManager.ConnectionStrings["OctaneDemo"].ConnectionString;
            }
            else
                connectionString = otherCS;

            if (has_Transactional_Queries)
            {
                _connection = new SqlConnection(connectionString);
                _connection.Open();
                _transaction = _connection.BeginTransaction(IsolationLevel.Serializable);
            }
        }

        public void ExecuteQuery(string query, bool isTransactional)
        {
            if (isTransactional)
            {
                _command = new SqlCommand();
                _command.Transaction = _transaction;
                _command.Connection = _connection;
                _command.CommandText = query;

                ErrorQuery = GetErrorQuery(_command.CommandText, null);
                _command.ExecuteNonQuery();
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;

                ErrorQuery = GetErrorQuery(command.CommandText, null);
                command.ExecuteNonQuery();

                connection.Close();
                command.Dispose();
                connection.Dispose();
            }

        }

        public void ExecuteQuery(QueryType queryType, string tableName, Dictionary<string, object> tableColumns, string whereClause, bool isTransactional)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string columnNames = string.Empty;
            string columnValues = string.Empty;
            string columnNvalues = string.Empty;
            string query = string.Empty;

            if (queryType != QueryType.DELETE)
            {

                foreach (KeyValuePair<string, object> col in tableColumns)
                {
                    SqlDbType dataType = SqlDbType.VarChar;

                    if (tableColumns[col.Key] == null)
                    {
                        continue;
                    }

                    if (tableColumns[col.Key].GetType().Equals(typeof(Int32))) { dataType = SqlDbType.Int; }
                    else if (tableColumns[col.Key].GetType().Equals(typeof(Byte))) { dataType = SqlDbType.TinyInt; }
                    else if (tableColumns[col.Key].GetType().Equals(typeof(decimal))) { dataType = SqlDbType.Decimal; }
                    else if (tableColumns[col.Key].GetType().Equals(typeof(DateTime))) { dataType = SqlDbType.DateTime; }
                    else if (tableColumns[col.Key].GetType().Equals(typeof(byte[]))) { dataType = SqlDbType.Binary; }
                    else if (tableColumns[col.Key].GetType().Equals(typeof(bool))) { dataType = SqlDbType.Bit; }

                    if (tableColumns[col.Key].ToString() != "EMPTY")
                    {
                        SqlParameter para = new SqlParameter();
                        para.ParameterName = col.Key;
                        para.Value = col.Value;
                        para.SqlDbType = dataType;
                        parameters.Add(para);
                    }
                }

            }

            switch (queryType)
            {
                case QueryType.INSERT:
                    string[] columnsIns = (from c in parameters select c.ParameterName).ToArray();
                    string[] values = (from p in parameters select "@" + p.ParameterName).ToArray();
                    columnNames = string.Join(", ", columnsIns);
                    columnValues = string.Join(", ", values);
                    query = "INSERT INTO " + tableName + " (" + columnNames + ")" + " VALUES (" + columnValues + ")";

                    if (isTransactional)
                    {
                        _command = new SqlCommand();
                        _command.Transaction = _transaction;
                        _command.Connection = _connection;
                        _command.CommandText = query;
                        _command.Parameters.AddRange(parameters.ToArray());

                        ErrorQuery = GetErrorQuery(_command.CommandText, _command.Parameters);
                        _command.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = query;
                        command.Parameters.AddRange(parameters.ToArray());

                        ErrorQuery = GetErrorQuery(command.CommandText, command.Parameters);
                        command.ExecuteNonQuery();

                        connection.Close();
                        command.Dispose();
                        connection.Dispose();
                    }
                    break;
                case QueryType.UPDATE:
                    string[] columnsUpd = (from c in parameters select c.ParameterName + " = " + "@" + c.ParameterName).ToArray();
                    columnNvalues = string.Join(", ", columnsUpd);
                    query = "UPDATE " + tableName + " SET " + columnNvalues + "" + " WHERE " + whereClause + "";

                    if (isTransactional)
                    {
                        _command = new SqlCommand();
                        _command.Transaction = _transaction;
                        _command.Connection = _connection;
                        _command.CommandText = query;
                        _command.Parameters.AddRange(parameters.ToArray());

                        ErrorQuery = GetErrorQuery(_command.CommandText, _command.Parameters);
                        _command.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = query;
                        command.Parameters.AddRange(parameters.ToArray());

                        ErrorQuery = GetErrorQuery(command.CommandText, command.Parameters);
                        command.ExecuteNonQuery();

                        connection.Close();
                        command.Dispose();
                        connection.Dispose();
                    }
                    break;
                case QueryType.DELETE:
                    query = "DELETE FROM " + tableName + " WHERE " + whereClause + "";
                    if (isTransactional)
                    {
                        _command = new SqlCommand();
                        _command.Transaction = _transaction;
                        _command.Connection = _connection;
                        _command.CommandText = query;

                        ErrorQuery = GetErrorQuery(_command.CommandText, null);
                        _command.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = query;

                        ErrorQuery = GetErrorQuery(command.CommandText, null);
                        command.ExecuteNonQuery();

                        connection.Close();
                        command.Dispose();
                        connection.Dispose();
                    }
                    break;

                default:
                    break;
            }
        }

        public DataTable GetRecord(string query, bool isTransactional)
        {
            DataTable dt = new DataTable();
            if (isTransactional)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                ErrorQuery = GetErrorQuery(query, null);
                adapter.SelectCommand.Transaction = _transaction;
                adapter.Fill(dt);
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                ErrorQuery = GetErrorQuery(query, null);
                adapter.Fill(dt);
                adapter.Dispose();

                connection.Close();
                connection.Dispose();

            }

            return dt;

        }

        public object GetObject(string query, bool isTransactional)
        {
            DataTable dt = new DataTable();

            if (isTransactional)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                ErrorQuery = GetErrorQuery(query, null);
                adapter.SelectCommand.Transaction = _transaction;
                adapter.Fill(dt);
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                ErrorQuery = GetErrorQuery(query, null);
                adapter.Fill(dt);

                adapter.Dispose();

                connection.Close();
                connection.Dispose();
            }

            return dt.Rows[0][0];

        }

        public void Commit()
        {
            try
            {
                if (_transaction != null)
                {
                    _transaction.Commit();

                    return;
                }
            }
            catch (Exception ex)
            {
                if (_transaction != null)
                    _transaction.Rollback();
                IsTransactionalError = true;

            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
                _transaction = null;
            }
        }


        public void DisposeTransaction()
        {
            if (_transaction != null)
                _transaction.Rollback();

            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
            _transaction = null;
        }


        private string GetErrorQuery(string cmdText, SqlParameterCollection sqlParams)
        {
            string _query = cmdText;

            if (sqlParams == null)
                return _query;

            foreach (SqlParameter param in sqlParams)
            {
                if (param.DbType == DbType.Int32) { _query = _query.Replace("@" + param.ParameterName, string.Format("{0}", param.Value)); }
                else if (param.DbType == DbType.Int16) { _query = _query.Replace("@" + param.ParameterName, string.Format("{0}", param.Value)); }
                else if (param.DbType == DbType.Decimal) { _query = _query.Replace("@" + param.ParameterName, string.Format("{0}", param.Value)); }
                else if (param.DbType == DbType.Double) { _query = _query.Replace("@" + param.ParameterName, string.Format("{0}", param.Value)); }
                else if (param.DbType == DbType.DateTime) { _query = _query.Replace("@" + param.ParameterName, string.Format("'{0}'", param.Value)); }
                else if (param.DbType == DbType.Binary) { _query = _query.Replace("@" + param.ParameterName, string.Format("{0}", param.Value)); }
                else if (param.DbType == DbType.Boolean) { _query = _query.Replace("@" + param.ParameterName, string.Format("{0}", (bool)param.Value ? 1 : 0)); }
                else if (param.DbType == DbType.String) { _query = _query.Replace("@" + param.ParameterName, string.Format("'{0}'", param.Value)); }
                else { _query = _query.Replace("@" + param.ParameterName, string.Format("'{0}'", param.Value)); }
            }
            return _query;
        }
        public enum QueryType
        {
            INSERT,
            UPDATE,
            DELETE
        }
    }

}