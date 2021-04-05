$(document).ready(function () {


    $("#btn1").click(function () {
        var name1 = $("#inpName").val();
        var age1 = $("#inpAge").val();
        var sex1 = $("#inpSex").val();

        $.ajax({
            url: "/API/UserHandler.ashx?token=12345",
            data: { "name": name1, "age": age1, "sex": sex1, "action": "create" },
            type: 'POST',
            dataType: 'json',
        })
            .done(function (data) {
           
            })
            .fail(function () {
                console.log('傳輸失敗');
            });
    });
});