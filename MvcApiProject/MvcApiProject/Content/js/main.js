$(function () {
    //
});

$("button").click(function () {
    $("#teste").empty();
    $.ajax({  
        url: 'http://localhost:4557/api/values',
        //url: 'http://api.diegoramalhodev.com/api/values/',
        type: 'GET',  
        dataType: 'json',  
        success: function(data, textStatus, xhr) {
            var countTotal = 0;
            var line = "";
            $.each(data, function () {
                $("#teste").append(line + data[countTotal]);
                line = "<br />";
                countTotal++;
            });
        },  
        error: function(xhr, textStatus, errorThrown) {  
        console.log('Error in Database');
        }  
    });  
});