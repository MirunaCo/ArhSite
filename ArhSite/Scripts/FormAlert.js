$(document).ready(function () {
    $("#contactform").submit(function (e) {
        e.preventDefault();
        if ($(this).valid()) {
            $.ajax({
                type: "POST",
                url: $(this).attr('action'),
                data: $(this).serialize(),
                dataType: 'json',
                success: function (res) {
                    if (res.success) {
                        $('#messages').removeClass('hide').html("<div class='alert alert-success alert-dismissible'>" + res.responseText + "</div>").slideDown().show();
                    } else {
                        $('#messages').removeClass('hide').html("<div class='alert alert-danger'>" + res.responseText + "</div>").slideDown().show();
                    }    
                },
                error: function (res) {
                    $('#messages').removeClass('hide').html("<div class='alert alert-danger'>" + res.responseText + "</div>").slideDown().show();
                }
                
            });
        }
    });

});