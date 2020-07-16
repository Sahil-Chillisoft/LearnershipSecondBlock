var dataTable;
var apiUri = "/api/Channels";

$(document).ready(function () {
    bindTable(apiUri);
});

function bindTable(uri) {
    dataTable = $("#channelsTable").DataTable({
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
            { "data": "name", "autoWidth": true },
            { "data": "description", "autoWidth": true },
            { "data": "dateCreated", "autoWidth": true }
        ],
        "language": {
            "emptyTable": "No channels found."
        },
        "width": "100%"
    });
}