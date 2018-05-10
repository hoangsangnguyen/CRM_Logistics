$(document).ready(function () {
    console.log("Welcome contacts-creater.js");
    LoadPositions();
    LoadDepartments();

    document.getElementById('save').addEventListener("click", function () {
        SaveContact();
    });
})

function SaveContact() {
    var model = $('#form_new').serializeObject();
    var request = JSON.stringify(model);
    console.log('modell : ' + request);
    $.ajax({
        url: "https://localhost:44395/contacts",
        type: "POST",
        dataType: "json",
        contentType: 'application/json',
        data: request,
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log(dataJS);
            window.location.replace("http://localhost:53723/contacts");

            //confirm("Create new contact succeed", function () {
            //    window.location.replace("http://localhost:53723/contacts");
            //}, false);
            //return;
        }
    });
}

function CreateNewCommodity() {
    var txt;
    var person = prompt("Please enter your name:", "Harry Potter");
    if (person == null || person == "") {
        txt = "User cancelled the prompt.";
    } else {
        var j = { "name": person };
        var request = JSON.stringify(j);
        console.log(request);
        $.ajax({
            url: "https://localhost:44395/commodities",
            type: "POST",
            dataType: "json",
            contentType: 'application/json',
            data: request,
            cache: false,
            async: false,
            success: function (dataJS) {
                console.log(dataJS);
            }
        });
    }
    console.log(txt);
    //document.getElementById("demo").innerHTML = txt;
}

function LoadPositions() {
    console.log('Enter loading positioins');
    $.ajax({
        url: "https://localhost:44395/positions",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log(dataJS);
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                console.log('Load positions succeed');
                $('#Position').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}

function LoadDepartments() {
    console.log('Enter loading positioins');
    $.ajax({
        url: "https://localhost:44395/departments",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log(dataJS);
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                console.log('Load departments succeed');
                $('#Department').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}