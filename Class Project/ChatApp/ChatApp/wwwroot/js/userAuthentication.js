var user = {
    "email": "",
    "password": ""
}

function authenticateUserLogin() {
    if (getUserLoginDetailsSuccess()) {
        $.ajax({
            url: "/api/UserAuthentication",
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify(user),
            success: function (data, status) {
                postResponse(data);
            },
            error: function (html, status, error) {
                console.log("An error has occured with the api response: " + error);
            }
        });
    }
    else {
        alert("Error: Please enter both email and password.");
        return;
    }
}

function getUserLoginDetailsSuccess() {
    user.email = $("#Email").val();
    user.password = $("#Password").val();
    if (user.email === "" || user.password === "") {
        return false;
    } else {
        return true;
    }
}

function postResponse(authenticationResponse) {
    //$.ajax({
    //    url: "/Login/PerformLoginAction?authenticationResponse=" + authenticationResponse,
    //    type: "POST",
    //    contentType: "application/json"
    //});
    if (authenticationResponse === "Authenticated") {
        window.location.href = "/Dashboard/Index";
    }
    else {
        window.location.href = "/Login/Index?loginStatus=loginFailed";
    }
}

