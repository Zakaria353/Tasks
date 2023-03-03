using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Webdriver.NET;

public class YahooPageWorker : Initializer
{
    private readonly string url = "https://www.yahoo.com/";

    public YahooPageWorker(IWebDriver driver) : base(driver)
    {

    }

    protected YahooElementMap Map
    {
        get
        {
            return new YahooElementMap(_driver);
        }
    }

    public YahooValidator Validate()
    {
        return new YahooValidator(_driver);
    }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(url);
    }

    public void ClickSignIn()
    {
        Map.Sign_In.Click();
    }

    public void SendUser(string textToType)
    {
        Map.EnterUserName.SendKeys(textToType);
    }

    public void ClickNext()
    {
        Map.ClickNext.Click();
    }

    public void SendPassword(string textToType)
    {
        IWebElement waitForElement = Wait.Until(e => e.FindElement(By.Id("login-passwd")));
        Map.EnterUserPassword.SendKeys(textToType);
    }

    public void ClickMail()
    {
        IWebElement waitForElement = Wait.Until(e => e.FindElement(By.Id("root_1")));
        Map.GotoInbox.Click();
    }

    public void ClickCompose()
    {
        Map.ComposeMail.Click();
    }

    public void MailTarget(string target)
    {
        Map.MailTarget.Click();
        Map.MailTarget.SendKeys(target);
        Map.MailTarget.Click();
    }

    public void MailSubject(string subject)
    {
        IWebElement elementToSearch = _driver.FindElement(By.XPath("//*[@placeholder='Subject']"));
        IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
        js.ExecuteScript("arguments[0].click()", elementToSearch);
        Map.MailSubject.SendKeys(subject);
    }

    public void MailContent(string content)
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@placeholder='Subject']")));
        Map.MailContent.Click();
        Map.MailContent.SendKeys(content);
    }

    public void SendMail()
    {
        Map.SendMail.Click();
    }

    public void GoToProfile()
    {
        Wait.Until(e => e.FindElement(By.XPath("//span[normalize-space('  TestEmailYahoo ' )][@role='presentation']")));
        Map.SelectProfile.Click();
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Account info']")));
        Map.SelectAccountInfo.Click();
    }

    public void EditProfile()
    {
        Wait.Until(e => e.FindElement(By.XPath("//a[text()='Edit']")));
        Map.EditAccountInfo.Click();
        Wait.Until(e => e.FindElement(By.XPath("//*[@id='updated-nickname']")));
        Map.EditNickname.Clear();
    }

    public void Changenickname(string nickname)
    {
        Map.EditNickname.SendKeys(nickname);
        Map.DoneEditing.Click();
    }
}