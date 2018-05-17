$(document).ready(function () {
    console.log("Hello Mr Sangg");
    LoadCommodity();
    LoadContacts();
    LoadShipments();
    LoadTypeOfBills();
    LoadUnits();
    LoadPayments();

    document.getElementById('save').addEventListener("click", function () {
        SaveAirExp();
    });
})

function SaveAirExp() {
    var model = $('#form_new').serializeObject();
    var checked = $('#checkbox1').is(":checked");

    model.isFinish = checked;
    var request = JSON.stringify(model);

    console.log('model : ' + request);

    $.ajax({
        url: "https://localhost:44395/airexps",
        type: "POST",
        dataType: "json",
        contentType: 'application/json',
        data: request,
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log(dataJS);
            window.location.replace("http://localhost:53723/airexps");
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

function LoadCommodity() {
    console.log('Enter loading commodity');
    $.ajax({
        url: "https://localhost:44395/commodities",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log('Load Commodities succeed');
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                $('#Commodity').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}

function LoadContacts() {
    console.log('Enter loading contacts');
    $.ajax({
        url: "https://localhost:44395/contacts",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log('Load Commodities succeed');
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                $('#opic').append($('<option>', {
                    value: item.id,
                    text: item.firstName + ' ' + item.lastName
                }));
            });

        }
    });
}

function LoadShipments() {
    console.log('Enter loading commodity');
    $.ajax({
        url: "https://localhost:44395/shipments",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log('Load shipments succeed');
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                $('#Shipment').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}

function LoadTypeOfBills() {
    console.log('Enter loading typeofbills');
    $.ajax({
        url: "https://localhost:44395/typeofbills",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log('Load types of bill succeed');
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                $('#billtype').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}

function LoadUnits() {
    console.log('Enter loading units');
    $.ajax({
        url: "https://localhost:44395/units",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log('Load units succeed');
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                $('#Unit').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}

function LoadPayments() {
    console.log('Enter loading payments');
    $.ajax({
        url: "https://localhost:44395/payments",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            console.log('Load payments succeed');
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                $('#Payment').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}
