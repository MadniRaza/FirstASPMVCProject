﻿$(document).ready(function ($) {
    var Body = $('body');
    Body.addClass('preloader-site');
});
$(window).on("load", function () {
    $('.preloader-wrapper').fadeOut();
    $('body').removeClass('preloader-site');
});

function CloseMainMenu() {
    if ($('body').hasClass('toggled')) {
        $("body").toggleClass("toggled");
    }
}


