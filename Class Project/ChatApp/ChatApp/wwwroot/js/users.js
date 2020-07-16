var dataTable;
var apiUri = "/api/Users";

$(document).ready(function () {
    bindTable(apiUri);
});

function bindTable(uri) {
    dataTable = $("#usersTable").DataTable({
        "processing": true,
        "filter": false,
        "paging": false,
        "scrollY": "200px",
        "ordering": false,
        "orderMulti": false,
        "info": false,
        "ajax": {
            "url": uri,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            //{ "data": "id", "autoWidth": true },
            { "data": "firstName", "autoWidth": true },
            { "data": "lastName", "autoWidth": true },
            { "data": "email", "autoWidth": true }
        ],
        "language": {
            "emptyTable": "No users found"
        },
        "width": "100%"
    });
}