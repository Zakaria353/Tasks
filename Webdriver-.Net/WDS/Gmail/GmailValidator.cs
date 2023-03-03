using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Webdriver.net;

public class GmailValidator : Initializer
{
    //public IWebDriver _driver;
    //public WebDriverWait Wait { get; set; }
    //public GmailValidator(IWebDriver driver)
    //{
    //    _driver = driver;
    //    Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
    //}

    public GmailValidator(IWebDriver driver) : base(driver)
    {  
    }

    protected GmailElementMap Map
    {
        get
        {
            return new GmailElementMap(_driver);
        }
    }

    public void ValidUserLogin(string expectedValue)
    {
        Wait.Until(e => e.FindElement(By.XPath("//a[text()='Inbox']")));
        Assert.True(Map.ValidLoginCheck.Text.Contains(expectedValue), "Unexpected Page");
    }

    public void InvalidUserLogin()
    {
        Assert.Fail("Invalid email account");
    }

    public void InvalidUserPassword()
    {
        Assert.Fail("Invalid email password");
    }

    public void UnreadMailCheck(string expectedValue)
    {
        Wait.Until(e => e.FindElement(By.Id(":25")));
        string? str = ((IJavaScriptExecutor)_driver).ExecuteScript("return document.getElementById(':25').textContent;").ToString();
        Assert.True(str?.Contains(expectedValue), "Mail is read");
    }

    public void SenderCheck(string expectedValue)
    {
        Wait.Until(e => e.FindElement(By.XPath("//span[text()='TTestMail444@gmail.com']")));
        Assert.True(Map.SenderCheck.Text.Equals(expectedValue), "Incorrect sender");
    }

    public void CheckMailReception(string expectedValue)
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@id=':2c']/span")));
        Assert.True(Map.MailSubject.Text.Equals(expectedValue), "Mail not received");
    }

    public void CheckMailContent(string expectedValue)
    {
        _driver.Navigate().Refresh();
        Wait.Until(e => e.FindElement(By.XPath("//*[@id=':26']/div/div/div")));
        Assert.True(Map.MailContent.Text.Equals(expectedValue), "Wrong mail content");
    }
}