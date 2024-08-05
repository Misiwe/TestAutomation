using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting.Tests;

public class TakeAlotTests
{
    IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver(Path.GetFullPath("../../../../" + "_drivers"));
        driver.Url = "https://www.takealot.com/";
    }

    [Test]
    public void Test1()
    {
        var page = new PageBase(driver);
        page.homePage.loginToTakealot();
        Assert.Pass();
    }

    [TearDown]         
    public void TearDown()        
    {            //Dispose of the driver hereif (driver != null) { driver.Quit(); driver.Dispose(); } }
         
        driver.Quit();
        driver.Dispose();
        
    }
}