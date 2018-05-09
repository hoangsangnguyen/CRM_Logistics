$(document).ready(function () {
    console.log("Hello Mr Sangg");
    LoadDataGrid();
})

function LoadDataGrid() {
    console.log('Enter loading data grid');
    $.ajax({
        url: "https://localhost:44395/airexps",
        type: "GET",
        dataType: "json",
        contentType: 'application/json',
        cache: false,
        async: false,
        success: function (dataJS) {
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