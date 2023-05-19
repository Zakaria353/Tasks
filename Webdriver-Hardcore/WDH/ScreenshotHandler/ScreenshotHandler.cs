using OpenQA.Selenium;

namespace WDH.GoogleCloud;

public class ScreenshotHandler : Initializer
{
    public ScreenshotHandler(IWebDriver driver) : base(driver)
    {

    }

    public ScreenshotHandler TakeScreenshots()
    {
        string currentTime = DateTime.Now.ToString();
        string filteredTime = currentTime.Replace(":", "#");
        string ScreenshotPath = @"C:\Users\user\source\repos\Webdriver Course\WDH\WDH\FailedTestScreenshots\";
        var scr = ((ITakesScreenshot)_driver).GetScreenshot();
        scr.SaveAsFile(ScreenshotPath + filteredTime + "_Screenshot.png",
            ScreenshotImageFormat.Png);
        return this;
    }
}