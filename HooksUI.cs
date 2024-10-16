[Binding]

[TestFixture]
public class LoginTests:BaseclassUI

[Setup]
public enum BrowserType
{
  Chrome,
  Firefox,
  Edge,
  Safari
}

private readonly ScenarioContext _scenarioContext;
private BrowserType _browserType;
public Browser(ScenarioContect scenarioContext)
{
  _scenarioContext = ScenarioContext;
  _browserType = (BrowserType)Enum.Parse(typeof(BrowserType)),
  ConfigurationManager.AppSetting["Browser"];
}

[BeforeScenario]
public void Setup() 
{
  switch (_browserType)
  {
      case BrowserType.Chrome:
      _driver = new ChromeDriver();
      break;
      
      case BrowserType.Firefox:
      _driver = new FireFoxDriver();
      break;

      case BrowserType.Edge:
      _driver = new EdgeDriver();
      break;

      case BrowserType.Safari:
      _driver = new SafariDriver();
      break;
  }
}

[AfterSenario]
public void TearDown ()
{
  if (-driver !=null)
  {
    _driver.Quit();
  }
    
}





