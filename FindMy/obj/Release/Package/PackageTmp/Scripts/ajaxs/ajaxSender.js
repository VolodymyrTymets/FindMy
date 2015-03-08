function AjaxSender() {

    this.getUsers = function (calback) {
        $.ajax({
            url: "/api/Location/GetAll",
            success: calback
        });
    }
    this.addUser = function (user,calback) {
        var json = JSON.stringify(user);

        $.ajax({
            url: '/api/Location/Set',
            type: 'POST',
            dataType: 'json',
            data: json,
            contentType: 'application/json; charset=utf-8',
            success: calback            
        })

    }
}