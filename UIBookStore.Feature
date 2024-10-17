Background:
Given User Launch the Browser

Senario: Login to BookStoreAPI
Given User Access the BookStoreURL "URL_UI"
When User Enters UserID "UserID_UI"
And User Enters Password "Password_UI"
And User Click on Login Button
Then User redirect to BookStore Dashboard page

Senario: Form Submission
Given User landed on FormPage
When User Enter User details
|Details | Values|
|FirstName | Sri|
|MIddleName| Ram |
|LastName | Varma|
|Gender | Male|
|Mobile | 9872346799|
|email | srv123@gmail.com|
And User click on Submit Button
Then System popsup as successfully Submitted


Scenario: API Creat User
Give I Have user with user details
When I send request to creat a new User
Then I should get responce with status code '201'
And the responce should contain user information









