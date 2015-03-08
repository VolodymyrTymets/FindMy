var CURRENTPOSITION;
$(document).ready(function () {
    var mapinit = new MapInitialiser();
    var ajaxsender = new AjaxSender();
   
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function (position) {
                CURRENTPOSITION = position;              
                ajaxsender.getUsers(mapinit.init);

            });
        } else {
            CURRENTPOSITION = null;           
            ajaxsender.getUsers(mapinit.init);
        }
       
        $("#send").click(function () {
            var user = {
                UserName : $("#userName").val(),
                latitude : CURRENTPOSITION.coords.latitude,
                longitude : CURRENTPOSITION.coords.longitude
            }
            ajaxsender.addUser(user, function (message) { alert(message); });
        });
});