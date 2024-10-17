public class Loginpageobjects
{
  private readonly IWebdriver _driver;
  private readonly IWebElement UsernameInput => _driver.FindElement(By.Id("Username"));
  private readonly IWebElement PasswordInput => _driver.FindElement(By.Id("password"));
  private readonly IWebElement LoginButton => _driver.FindElement(By.Id("LoginBtn"));
  private readonly IWebElement Elements=> _driver.FindElement(By.Xpath[@class="avatar mx-auto white"][text()= "Elements"]));
  private readonly IWebElement Forms=> _driver.FindElement(By.Xpath[@class="avatar mx-auto white"][text()= "Forms"]));
  private readonly IWebElement Alerts => _driver.FindElement(By.Xpath[@class="avatar mx-auto white"][text()= "Alerts"]));
  private readonly IWebElement Widgets => _driver.FindElement(By.Xpath[@class="avatar mx-auto white"][text()= "Widgets"]));
  private readonly IWebElement Interactions => _driver.FindElement(By.Xpath[@class="avatar mx-auto white"][text()= "Interactions"]));
}
