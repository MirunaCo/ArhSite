$(document).ready(function () {
    $("#contactform").submit(function (e) {
        e.preventDefault();
        if ($(this).valid()) {
            $.ajax({
                type: "POST",
                url: $(this).attr('action'),
                data: $(this).serialize(),
                success: function (res) {
                    $('#messages').removeClass('hide').addClass('alert alert-success alert-dismissible').slideDown().show();
                },
                error: function (request, status, error) {
                    $('#messages').removeClass('hide').addClass('alert alert-danger alert-dismissible').slideDown().show();
                }
                
            });
        }
    });

});