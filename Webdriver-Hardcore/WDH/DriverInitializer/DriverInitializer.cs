using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace WDH.GoogleCloud;

public class Initializer
{
    public IWebDriver _driver;
    public static WebDriverWait Wait { get; set; }
    public static IWebDriver Driver { get; set; }

    public Initializer(IWebDriver driver)
    {
        _driver = driver;
        Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        driver.Manage().Window.Maximize();
    }

    public static void BrowserSelector(string browser)
    {
        switch (browser)
        {   
            case "chrome":
                new DriverManager().SetUpDriver(new ChromeConfig());
                Driver = new ChromeDriver(); break;
            case "edge":
                new DriverManager().SetUpDriver(new EdgeConfig());
                Driver = new EdgeDriver(); break;
            case "firefox":
                new DriverManager().SetUpDriver(new FirefoxConfig());
                Driver = new FirefoxDriver(); break;
            default:
                throw new NotFoundException();
        }
    }
}