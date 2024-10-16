
public class BaseUIclass
{
  protected readonly IWebDriver _driver;
  public Basepage (IWebDriver driver)
  {
    _driver = driver;
  }
  public void NavigateTo(string URL_UI)
  {
    _driver.Navigate().GoToUrl(URL_UI);
  }
  public void WaitForElement(IWebElement element)
  {
    webDriverWait wait = new WebDriverWait (_driver, TimeSpan.FromSeconds(10));
    wait.until(driver=> element.Displayed);
  }
  
}
