$(document).ready(function () {
    console.log("Welcome contacts-create.js");
    //LoadCommodity();
    document.getElementById('save').addEventListener("click", function () {
        SaveContact();
    });
})

function SaveContact() {
    var model = $('#form_new').serializeObject();
    var request = JSON.stringify(model);
    console.log('modell : ' + request);
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
            console.log(dataJS);
            var datas = dataJS.data;

            $.each(datas, function (i, item) {
                console.log(item);
                $('#Commodity').append($('<option>', {
                    value: item.id,
                    text: item.name
                }));
            });

        }
    });
}