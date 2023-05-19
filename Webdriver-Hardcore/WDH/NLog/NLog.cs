using NLog;
using OpenQA.Selenium;
using WDH.GoogleCloud;

namespace WDH;

public class TestLogger : Initializer
{
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    public TestLogger(IWebDriver driver): base(driver)
    {

    }

    public void LogError(string exception)
    {
        logger.Error(exception);
        LogManager.Shutdown();
    }
}