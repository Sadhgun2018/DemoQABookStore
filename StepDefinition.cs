[Binding]
public class LoginSteps
{  
   private IWebDriver driver;
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


[Given (@"User landed on FormPage")
    public void GivenUserlandedonFormPage
    {
       Objects.FormBanner();
    }
 
When User Enter User details
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
 

And User click on Submit Button
Then System popsup as successfully Submitted

    
          
         
}
