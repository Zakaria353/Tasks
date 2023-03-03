using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Webdriver.net;


public class Initializer
{
    public IWebDriver _driver;
    public WebDriverWait Wait { get; set; }

    public Initializer(IWebDriver driver)
    {
        _driver = driver;
        Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        //driver.Manage().Window.Maximize();
    }
}