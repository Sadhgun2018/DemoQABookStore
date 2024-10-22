
public class UIActions
{
  private readonly IWebDriver _driver;
  public void UIActions(IWebDriver driver);
  {
    _driver = driver;
  }
  public void ClickElement(IWebElement element)
  {
    element.Click();
  }
  public void Entertext(IWebElement element, string text)
  {
    element.Clear();
    element.Sendkeys(text);
  }
  public bool IsElementVisible(IWebElement element)
  {
    return element.Displayed;
  }
  public void WaitForElement (IWebElement element)
  {
    WebDriverWait Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
    Wait.until(driver => element.Displayed);
  }
  public void TakeScreeshot ()
  {
    var Screenshot = ((ITakeScreenshot)Driver).GetScreenshot();
  }

}

public class APITokenManager
  {
    public static string GetAuthToken();
    {
      return "Generated Token";
    }    
  }
public class APIUils
  {
    public static T DeserializeResponce<T>(IRestResponse response)
    {
      return JsonConvert.DeserializeObject<T>(responce.Content);
    }
  }
