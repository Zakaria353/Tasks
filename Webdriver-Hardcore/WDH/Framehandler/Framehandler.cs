using OpenQA.Selenium;

namespace WDH.GoogleCloud;

internal class Framehandler : Initializer
{
    public Framehandler(IWebDriver driver) : base(driver)
    {

    }

    public static void CloudFrameHandler()
    {
        Wait?.Until(e => e.FindElement(By.XPath("//*[@id='cloud-site']/devsite-iframe/iframe")));
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//*[@id='cloud-site']/devsite-iframe/iframe")));

        Wait?.Until(e => e.FindElement(By.XPath("//*[@id='myFrame']")));
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//*[@id='myFrame']")));
    }

    public static void MailFrameHandler()
    {
        Wait?.Until(e => e.FindElement(By.XPath("//*[@name='ifmail']")));
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//*[@name='ifmail']")));
    }
}