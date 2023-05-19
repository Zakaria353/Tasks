using OpenQA.Selenium;

namespace WDH.GoogleCloud;

public class MailElementMap : Initializer
{
    public MailElementMap(IWebDriver driver) : base(driver)
    {

    }

    public IWebElement GenerateMail
    {
        get
        {
            return _driver.FindElement(By.XPath("//a[@title='Generate a random email address']"));
        }
    }

    public IWebElement CopyMail
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='cprnd']/span"));
        }
    }

    public IWebElement MailInbox
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='egen']/following::*[contains(text(), 'Check Inbox')]"));
        }
    }

    public IWebElement MailContent
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[normalize-space()='Estimated Monthly Cost: USD 3,649.97']"));
        }
    }
}