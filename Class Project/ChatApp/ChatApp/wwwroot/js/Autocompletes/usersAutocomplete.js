$(document).ready(function () {
    $("#search").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/api/Users/GetUsersForAutocomplete?searchParameter=" + request.term,
                type: "GET",
                dataType: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.email, value: item.email };
                    }));
                }
            });
        },
        error: function (xhr, status, error) {
            console.log("Error retrieving data for auto-complete.");
        }
    });
})