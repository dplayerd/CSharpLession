$(document).ready(function () {

    $("#btn1").click(function () {
        var name1 = $("#inpName").val();

        $.ajax({
            url: "/API/QueryUser.ashx",
            data: { "name": name1 },
            type: 'GET',
            dataType: 'json',
        })
            .done(function (data) {
                //console.log(data);

                var outputText = JSON.stringify(data);
                $('#divContainer').empty();
                //$('#divContainer').html('');
                $("#divContainer").append("<p>" + outputText + "</p>");
            })
            .fail(function () {
                console.log('傳輸失敗');
            });
    });
});



    // $.ajax({
    //     url: '/API/QueryUser.ashx',
    //     data: { id: 'a001' },
    //     type: 'GET',
    //     dataType: 'json',
    // })
    //     .done(function (jsonArr) {
    //         console.log(jsonArr);

    //         for (var i = 0; i < jsonArr.length; i++) {
    //             var html = "<p><span>" +
    //                 jsonArr[i].UserName + "</span><span>" +
    //                 jsonArr[i].Age + "</span><span>" +
    //                 jsonArr[i].Sex + "</span></p>";

    //             $("body").append(html);
    //         }
    //     })
    //     .fail(function (xhr, status, errorThrown) {
    //         console.log('出現錯誤，無法完成!');
    //         console.log('Error: ' + errorThrown);
    //         console.log('Status: ' + status);
    //         console.dir(xhr);
    //     })


