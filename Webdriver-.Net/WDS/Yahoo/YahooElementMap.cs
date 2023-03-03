using OpenQA.Selenium;

namespace Webdriver.net;

public class YahooElementMap : Initializer
{
    //public IWebDriver _driver;

    public YahooElementMap(IWebDriver driver): base(driver)
    {
        //_driver = driver;
    }

    public IWebElement Sign_In
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='ybarAccountProfile']/a"));
        }
    }

    public IWebElement EnterUserName
    {
        get
        {
            return _driver.FindElement(By.Id("login-username"));
        }
    }

    public IWebElement ClickNext
    {
        get
        {
            return _driver.FindElement(By.Id("login-signin"));
        }
    }

    public IWebElement EnterUserPassword
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='login-passwd']"));
        }
    }

    public IWebElement ValidLoginCheck
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[text()='  TestEmailYahoo ']"));
        }
    }

    public IWebElement InvalidLoginCheck
    {
        get
        {
            return _driver.FindElement(By.Id("username-error"));
        }
    }

    public IWebElement InvalidPasswordCheck
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@data-error='messages.ERROR_INVALID_PASSWORD']"));
        }
    }

    public IWebElement GotoInbox
    {
        get
        {
            return _driver.FindElement(By.Id("root_1"));
        }
    }

    public IWebElement ComposeMail
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@data-test-id='compose-button']"));
        }
    }

    public IWebElement MailTarget
    {
        get
        {
            return _driver.FindElement(By.Id("message-to-field"));
        }
    }

    public IWebElement MailSubject
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@placeholder='Subject']"));
        }
    }

    public IWebElement MailContent
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='editor-container']/div[1]"));
        }
    }

    public IWebElement SendMail
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@data-test-id='compose-send-button']"));
        }
    }

    public IWebElement SelectProfile
    {
        get
        {
            return _driver.FindElement(By.XPath("//span[normalize-space('  TestEmailYahoo ' )][@role='presentation']"));
        }
    }

    public IWebElement SelectAccountInfo
    {
        get
        {
            return _driver.FindElement(By.XPath("//a[text()='Account info']"));
        }
    }

    public IWebElement EditAccountInfo
    {
        get
        {
            return _driver.FindElement(By.XPath("//a[text()='Edit']"));
        }
    }

    public IWebElement EditNickname
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='updated-nickname']"));
        }
    }

    public IWebElement DoneEditing
    {
        get
        {
            return _driver.FindElement(By.XPath("//a[text()='Done']"));
        }
    }

    public IWebElement ValidateNickname
    {
        get
        {
            return _driver.FindElement(By.XPath("//div[@id='txt-nickname']"));
        }
    }
}