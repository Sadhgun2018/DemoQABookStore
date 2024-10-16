
BackGround: 
Given User Access the APICalls Tool with Admin


Senario: Login to BookStoreAPI
Given User Access the BookStoreURL "URL_API"
When User Enters UserID "UserID_API"
And User Enters Password "Password_API"
And User send the Post call with Request file "Request.Json" at path "sourcefilepath/local/Request.Json"
Then User validate the Response status as "200" ok

