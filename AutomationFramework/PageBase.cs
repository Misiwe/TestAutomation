using OpenQA.Selenium;

namespace AutomationFramework;

public class PageBase
{
    public readonly HomePage homePage;

    public PageBase(IWebDriver driver)
    {
        homePage = new HomePage(driver);
    }
}   
