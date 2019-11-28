// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(function () {
    $('button[data-toggle="ajax-modal"]').click(function (event) {

        var url = '/Index?handler=ContactModalPartial';
        $.get(url).done(function (data) {

            $(document).append(data).find('.modal').modal('show');
        });
    });
});