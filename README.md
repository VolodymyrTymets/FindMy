# FindMy
Server for FindMy Program<br/>
    server hosting hear: [www.findmy.somee.com](http://www.findmy.somee.com)<br/>
## Api
* get All users
  `http://www.findmy.somee.com/api/Location/GetAll?r=5&lat=20.455&lon=30.45` <br />
* get single user
  `http://www.findmy.somee.com/api/Location/GetFriend?UserName=user1` <br />

* set user
  `/api/Location/Set` <br />
  **Data to send** <br />
  >
    { <br/>
      UserName : name, <br/>
      latitude:21.5456, <br/>
      longitude:26.5546 <br/>
    } <br/>
   
