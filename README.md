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


