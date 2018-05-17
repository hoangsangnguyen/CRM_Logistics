$(document).ready(function () {
    console.log("Hello Mr Sang");

    var id = '';

    LoadDataGrid();
    //document.getElementById('btn_update').addEventListener("click", function () {
    //    console.log('id: ' + id);
    //});
    

})

function LoadDataGrid() {
    console.log('Enter loading data gridd');
    $.ajax({
        url: "https://localhost:44395/airexps",
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

            const monthNames = ["January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            ];

            var table = $('#example').DataTable({
                destroy: true,
                data: dataJS.data,
                select: true,
                "columns": [
                    { "data": "jobID" },
                    {
                        "data": "etd",
                        "render": function (data) {
                            var date = new Date(data);
                            var month = monthNames[date.getMonth()];
                            return (date.getDate() + " " + month + ", " + date.getFullYear());
                        }
                    },
                    { "data": "carrier" },
                    { "data": "carrier"},
                    { "data": "eta" },
                    { "data": "quantity" },
                    { "data": "quantity" },
                    { "data": "quantity" },
                ],
                dom: 'Bfrtip',

                buttons: [
                    'copy', 'excel', 'pdf'
                ],
               
            }); 

            table.on('select', function (e, dt, type, indexes) {
                var rowData = table.rows(indexes).data().toArray();
                $('#btn_update').prop('disabled', false);
                $('#btn_delete').prop('disabled', false);
                id = rowData[0].id;

                document.getElementById('btn_update').addEventListener("click", function () {
                    window.location.replace("/airexps/AddEdit/" + id);
                    console.log('id: ' + id);
                });
                console.log(rowData[0].id);
            })
                .on('page.dt', function () {
                    table.rows().deselect();
                    $('#btn_update').prop('disabled', true);
                    $('#btn_delete').prop('disabled', true);

                })

            

        }
    });
}