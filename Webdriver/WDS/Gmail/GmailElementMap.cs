using OpenQA.Selenium;

namespace Webdriver.NET;

public class GmailElementMap: Initializer
{
    public GmailElementMap(IWebDriver driver): base(driver)
    {

    }

    public IWebElement Sign_In
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[text()='Sign in']"));
        }
    }

    public IWebElement EnterUserName
    {
        get
        {
            return _driver.FindElement(By.Id("identifierId"));
        }
    }

    public IWebElement ClickNext
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[text()='Next']"));
        }
    }

    public IWebElement EnterUserPassword
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));
        }
    }

    public IWebElement ValidLoginCheck
    {
        get
        {
            return _driver.FindElement(By.XPath("//a[text()='Inbox']"));
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

    public IWebElement UnreadMail
    {
        get
        {
            return _driver.FindElement(By.XPath("//div[@class='afn'][contains(text(),'unread')]"));
        }
    }

    public IWebElement SelectMail
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id=':27']"));
        }
    }

    public IWebElement GotoMail
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id=':2a']"));
        }
    }

    public IWebElement SenderCheck
    {
        get
        {
            return _driver.FindElement(By.XPath("//span[text()='TTestMail444@gmail.com']"));
        }
    }

    public IWebElement MailSubject
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id=':2c']/span"));
        }
    }

    public IWebElement MailContent
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id=':26']/div/div/div"));
        }
    }

    public IWebElement ReplyButton
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[text()='Reply']/following-sibling::*/preceding-sibling::*"));
        }
    }

    public IWebElement SelectResponse
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@aria-label='Type of response']"));
        }
    }

    public IWebElement EditSubject
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[text()='Edit subject']"));
        }
    }

    public IWebElement SelectRecepients
    {
        get
        {
            return _driver.FindElement(By.XPath("//table[@class='IG']"));
        }
    }

    public IWebElement AddRecepients
    {
        get
        {
            return _driver.FindElement(By.XPath("//input[@type='text'][@aria-haspopup='listbox']"));
        }
    }

    public IWebElement Response
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@aria-label='Message Body'][@aria-multiline='true']"));
        }
    }

    public IWebElement SendResponse
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[text()='Send']"));
        }
    }
}