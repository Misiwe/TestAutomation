using OpenQA.Selenium;

namespace AutomationFramework;

public class HomePage
{
    public readonly HomePageMap map;  
    public HomePage(IWebDriver driver)
    {
        map = new HomePageMap(driver);
    }

   public void loginToTakealot()
   {
        map.btnLogin.Click();
   }   
}  

public class HomePageMap
{
    IWebDriver driver;
    public HomePageMap(IWebDriver _driver)
    {
        driver = _driver;
    }

    public IWebElement btnLogin => driver.FindElement(By.XPath("//a[text()='Login']"));
}
