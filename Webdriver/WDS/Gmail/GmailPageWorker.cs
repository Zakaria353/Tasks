using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Webdriver.NET;

public class GmailPageWorker : Initializer
{
    private readonly string url = "https://www.gmail.com/";

    public GmailPageWorker(IWebDriver driver) : base(driver)
    {

    }

    protected GmailElementMap Map
    {
        get
        {
            return new GmailElementMap(_driver);
        }
    }

    public GmailValidator Validate()
    {
        return new GmailValidator(_driver);
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
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='Next']")));
        Map.ClickNext.Click();
    }

    public void SendPassword(string textToType)
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='password']/div[1]/div/div[1]/input")));
        Map.EnterUserPassword.SendKeys(textToType);
    }

    public void ClickAndGotoMail()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@id=':27']")));
        Map.SelectMail.Click();
        Wait.Until(e => e.FindElement(By.XPath("//*[@id=':2a']")));
        Map.GotoMail.Click();
    }

    public void ClickReplyButton()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[text()='Reply']/following-sibling::*/preceding-sibling::*")));
        Map.ReplyButton.Click();
    }

    public void SelectContacts()
    {
        Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//table[@class='IG']")));
        Map.SelectRecepients.Click();
        Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='text'][@aria-haspopup='listbox']")));
    }

    public void ChooseContacts(string recepient)
    {
        Map.AddRecepients.Clear();
        Map.AddRecepients.SendKeys(recepient);
    }

    public void Response(string response)
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@aria-label='Message Body'][@aria-multiline='true']")));
        Map.Response.SendKeys(response);
    }

    public void SendResponse()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[text()='Send']")));
        Map.SendResponse.Click();
    }

    static void Main()
    {

    }
}