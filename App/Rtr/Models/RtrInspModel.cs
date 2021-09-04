using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OctaneApp.App.Rtr.Models
{
    public class RtrInspModel
    {
        [Display(Name = "Unit Label")]
        public string UnitLabel { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

        public string PF { get; set; }

        public string Station { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Defect")]
        public string Defect { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; }

        [Display(Name = "Due To")]
        public string DueTo { get; set; }

        [Display(Name = "Top/Bottom")]
        public string TB { get; set; }

        [Display(Name = "SN Impacted")]
        public string SNImpacted { get; set; }

          [Display(Name = "Route Comments")]
        public string RouteComments { get; set; }



    }
}