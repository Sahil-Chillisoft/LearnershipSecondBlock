$(document).ready(function () {
    $("#search").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/api/Channels/GetChannelsForAutocomplete?searchParameter=" + request.term,
                type: "GET",
                dataType: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.name, value: item.name };
                    }));
                }
            });
        },
        error: function (xhr, status, error) {
            console.log("Error retrieving data for auto-complete.");
        }
    });
})