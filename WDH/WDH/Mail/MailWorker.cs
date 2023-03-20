using OpenQA.Selenium;

namespace WDH.GoogleCloud;

public class MailWorker : Initializer
{
    private readonly string url = "https://yopmail.com/";

    public MailWorker(IWebDriver driver) : base(driver)
    {

    }

    protected MailElementMap Map
    {
        get
        {
            return new MailElementMap(_driver);
        }
    }

    public MailValidator Validate()
    {
        return new MailValidator(_driver);
    }

    public MailWorker Navigate()
    {
        ((IJavaScriptExecutor)_driver).ExecuteScript("window.open();");
        _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        _driver.Navigate().GoToUrl(url);
        return this;
    }

    public MailWorker GenerateMail()
    {
        Map.GenerateMail.Click();
        return this;
    }

    public MailWorker CopyMail()
    {
        Map.CopyMail.Click();
        _driver.SwitchTo().Window(_driver.WindowHandles.First());
        return this;
    }

    public MailWorker GotoInbox()
    {   
        _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        Map.MailInbox.Click();
        return this;
    }
}