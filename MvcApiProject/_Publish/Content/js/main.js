$(function () {
    //
});

$("button").click(function () {
    $.ajax({  
        //url: 'http://localhost:4557/api/values',
        url: 'http://api.diegoramalhodev.com/api/values/',
        type: 'GET',  
        dataType: 'json',  
        success: function(data, textStatus, xhr) {
            var countTotal = 0;
            $.each(data, function () {
                $("#teste").append(data[countTotal] + "<br/>");
                countTotal++;
            });
        },  
        error: function(xhr, textStatus, errorThrown) {  
        console.log('Error in Database');
        }  
    });  
});