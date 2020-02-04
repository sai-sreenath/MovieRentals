# MovieRentals

Code-First Migrations
----------------------

add-migration migrationname to create a migration 

update-Database command to convert all the migrations data into database.

Forms
-----
If you use labelfor in the html and run the application,If you click on the label,then textbox will be focussed

If you use plain label tags,then on clicking the lable,textbox wont get focussed.

validations
-----------
Data annotations are used for both client side and server side validations

But,client side validations only work with Data standard data annotations like 
[Required]
[Stringlength(255)]
[Range(1,10)]
[Compare("other property")]
[Phone]
[EmailAddress]
[URL]
[RegularExpression("   ")]
custom validations wont be having client side support by default.

we have to write the jquery code inorder to make custom validations client side.

To check if we validations are running at client/server end,go to networks tab and see the data.
If present,then we are executing at server end,otherwise client end.

Anti-forgery tokens
--------------------
open network tab and click on save request in customerscontroller.
Now we get HttpPostRequest tab in networks tab.
on Scrolling down,we see form data being displayed in the body of the request.
Now,if the user responsible for creating a customer leaves the site without signing out,then he has active session on the server. 
Now,this data can be used to visit a malicious page. 
Because this user has an active session on our Web site,These requests will be successfully executed on his behalf.
We call this kind of attack C S R F or C serve which stands for Krus side request forgery.
So the hacker forges a request on a different web site and with this technique they can literally execute
any actions on behalf of the victim.


OAUTH and Social Logins
-----------------------
1)We use an authentication protocol called OSS which stands for open authorization.

2)Let's say John is a new staff member and wants to log into widley with his Facebook account.
First of all we need to register our application with Facebook to create some kind of partnership.
Facebook will give us an API key and a secret kind of like a username password.
We'll use this to talk to Facebook under the hood.

3)Now John wants to log in when he clicks on Facebook log in on our Web site.
We will redirect him to Facebook and we'll use our API key and secret.
So Facebook knows this request is coming from Video rentals now to prevent a malicious user from finding our secret.

4)We use HTP as or secure HDTV protocol so the data exchange between these parties will be encrypted and
no one can intercept this communication.
OK now Joe is on Facebook.
He logs in with his username and password on the VideoRentals site.
We don't know and we don't care what his Facebook credentials are.
Once he logs into Facebook,Facebook tells him that widley wants to access some basic information about
his account.

5)Since we registered with Facebook at the beginning.
Facebook knows the address of Video Rentals, so it will redirect back to our site and it will also pass an
authorization token. This authorization token tells our site that Facebook could successfully authenticate
this user.

Now on our site, we get this authorization token and send it back to Facebook with our API key and secret.
We do this because a hacker may send a random authorisation token to our site.
So we need to verify that it really came from Facebook.
That's why we send it back and tell Facebook hey it's me.

Once Facebook says yes it gave,
And then it will give us an Access token with which we can access some parts of the user's
profile.

Steps to Use social Logins
--------------------------
1)First,we need to enable SSL,so that our communication will be on secure channel.
2)We need to register our application with Facebook,Google ,linkedin or any other social platforms.
SSL is enbaled in Project in Solution explorer - click F4 -> set SSL Enabled=true

Lazy Loading
------------
1)If you have N customers in the database,we will have one query to get list of customers and N queries to get membershiptype for each
customer.(worst case scenario-(N+1) issue)

Glimpse -Performance optimization tool
--------------------------------------
1) With glimpse,you can easily keep an eye on quieries running in the database by the Entity Framework.
2)If you find a slow page in the website,open glimpse and see whats happening inside. like what queries are being run on the database,
Execution time of each quieries.
3)If you find Entity Framework Query that shows to be slow,then optimize it by creating the stored procedure and calling it via DBContext. 

Caching:
--------
If the view is specific to a given user,put it on client otherwise put it on server with paramater
Location = OutputCacheLocation.Server

Building Feature systematically:
--------------------------------
1)Understand the problem
2)start with the backend
3)Think of the inputs and outputs 
4)Declare a simple API
5)Extend the domain model(if required)
6)Build the application
7)Add the details one by one
8)Move on to the Front-end




