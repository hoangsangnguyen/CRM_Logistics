$(document).ready(function () {
    console.log("welcome to contact.js");
    LoadDataGrid();
})

function LoadDataGrid() {
    console.log('Enter loading data grid');
    $.ajax({
        url: "https://localhost:44395/contacts",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
            if (jQuery.isEmptyObject(dataJS.data)) {
                console.log('No data response');
                $('#example').DataTable();
                return;
            }

            $('#example').DataTable({
                destroy: true,
                data: dataJS.data,
                "columns": [
                    { "data": "jobID" },
                    { "data": "etd" },
                    { "data": "service" },
                    { "data": "etd" },
                    { "data": "eta" },
                    { "data": "commodityId" },
                    { "data": "quantity" },
                    { "data": "commodityId" }
                ]
            });

        }
    });
}