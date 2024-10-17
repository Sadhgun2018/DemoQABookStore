[Binding]
public class LoginSteps
{  
   private IWebDriver driver;   
   private RestClient client;
   private RestRequest request;
   private IRestResponse response;
   private Userservice _UserService;
   private IRestResponse _response;
   private LoginPage _loginPage
   {
      _loginPage = new LoginPage;
   }
   

   [Given (@"User Launch the Browser"]
           public void GivenUserLaunchtheBrowser()
           {
              _driver =driver;
           }
   
  [Given (@"User Access the BookStoreURL "(.*)")]
          public void GivenUserAccesstheBookStoreURL (string url)
          {
            _Loginpage.NavigateToLoginPage();
          }

   [When (@"User Enters UserID "(.*)")
          public void WhenUserEntersUserID(string User)
          {
             _loginPage.EnterUsername(User);
          }

   [When (@"User Enters Password "(.*)")
          public void WhenUserEntersUserID(string password)
          {
             _loginPage.Enterpassword(password);
          }

   [When (@"User Click on Login Button")
          public void WhenUserClick on Login Button(IWebElement element)
          {
             _loginPage.element.ClickLogin();
          }


[Given (@"User landed on FormPage")]
    public void GivenUserlandedonFormPage
    {
       Objects.FormBanner();
    }
 
 [When (@"User Enter User details")]
   public void WhenUserEnterUserdetails(table Table)
    {
    Dictionaty <string, string> UserDetails = new Dictionary <string, string>(Table);
    Objects.Firstname.EnterText(Table.FirstName.value);
    Objects.MIddleName.EnterText(Table.MIddleName.value);
    Objects.LastName.EnterText(Table.LastName.value);
    Objects.Gender.EnterText(Table.Gender.value);
    Objects.Mobile.EnterText(Table.Mobile.value);
    Objects.email.EnterText(Table.email.value);
    
    }
 

[When (@"User click on Submit Button")]
 public void WhenUserclickonSubmitButton(IWebElement element)
 {
    Objects.element.Click();
 }
 
[Then (@"System popsup as successfully Submitted")]
    public void ThenSystempopsupassuccessfullySubmitted(string massage)
    {
       Assert.AreEqual("successfully Submitted", massage);
    }



      public CreateUserSteps(string URL_API)
        {
            client = new RestClient(URL_API);
        }

   [Given(@"I have the user details")]
        public void GivenIHaveTheUserDetails()
        {            
            request = new RestRequest("users", Method.POST);
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                name = "Ram Varma",
                email = "RamVarma@gmail.com",
                password = "password123"
            };
            request.AddJsonBody(body);
        }

   [When(@"I send a request to create a new user")]
        public void WhenISendARequestToCreateANewUser()
        {
            response = client.Execute(request);
        }

   [Then(@"I should get a response with status code (.*)")]
        public void ThenIShouldGetAResponseWithStatusCode(int statusCode)
        {
            Assert.AreEqual((HttpStatusCode)statusCode, response.StatusCode);
        }

   [Then(@"the response should contain the user information")]
        public void ThenTheResponseShouldContainTheUserInformation()
        {
            Assert.IsTrue(response.Content.Contains("Ram Varma"));
            Assert.IsTrue(response.Content.Contains("RamVarma@gmail.com"));
        }
          
         
}
