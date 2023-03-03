using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Webdriver.net;
using Xunit.Abstractions;

namespace EmailTests;

public class EmailTests : IDisposable
{
    public ITestOutputHelper _testOutputHelper;
    public IWebDriver Driver { get; set; }

    public GmailPageWorker _gmailMainPage;
    public YahooPageWorker _yahooMainPage;

    public EmailTests(ITestOutputHelper testOutputHelper)
    {
        Driver = new ChromeDriver();

        _gmailMainPage = new GmailPageWorker(Driver);
        _yahooMainPage = new YahooPageWorker(Driver);
        _testOutputHelper = testOutputHelper;        
    }

    public void Dispose()
    {
        Thread.Sleep(3000);
        Driver.Quit();
    }
}

public class GmailAccountTests : EmailTests
{
    public GmailAccountTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    [Fact]
    public void LoginTest()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("TTestMail444");
        _gmailMainPage.ClickNext();
        _gmailMainPage.SendPassword("x6KJgTDw2Khk4Nc");
        _gmailMainPage.ClickNext();
        _gmailMainPage.Validate().ValidUserLogin("Inbox");
    }

    [Fact]
    public void InvalidUsernameTest()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("-ABCD--");
        _gmailMainPage.ClickNext();
        _gmailMainPage.Validate().InvalidUserLogin();
    }

    [Fact]
    public void InvalidPasswordTest()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("TTestMail444");
        _gmailMainPage.ClickNext();
        _gmailMainPage.SendPassword("abcd");
        _gmailMainPage.ClickNext();
        _gmailMainPage.Validate().InvalidUserPassword();
    }

    [Fact]
    public void MailArrivalCheck()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("TTestMail444");
        _gmailMainPage.ClickNext();
        _gmailMainPage.SendPassword("x6KJgTDw2Khk4Nc");
        _gmailMainPage.ClickNext();
        _gmailMainPage.Validate().CheckMailReception("Test mail");
    }

    [Fact]
    public void MailUnreadCheck()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("TTestMail444");
        _gmailMainPage.ClickNext();
        _gmailMainPage.SendPassword("x6KJgTDw2Khk4Nc");
        _gmailMainPage.ClickNext();
        _gmailMainPage.Validate().UnreadMailCheck("unread");
        //string? str = ((IJavaScriptExecutor)Driver).ExecuteScript("return document.getElementById(':25').textContent;").ToString();
        //_testOutputHelper.WriteLine(str);
    }

    [Fact]
    public void MailSenderCheck()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("TTestMail444");
        _gmailMainPage.ClickNext();
        _gmailMainPage.SendPassword("x6KJgTDw2Khk4Nc");
        _gmailMainPage.ClickNext();
        _gmailMainPage.ClickAndGotoMail();
        _gmailMainPage.Validate().SenderCheck("TTestMail444@gmail.com");
    }

    [Fact]
    public void MailContentCheck()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("TTestMail444");
        _gmailMainPage.ClickNext();
        _gmailMainPage.SendPassword("x6KJgTDw2Khk4Nc");
        _gmailMainPage.ClickNext();
        _gmailMainPage.ClickAndGotoMail();
        _gmailMainPage.Validate().CheckMailContent("Test mail from yahoo");
    }

    [Fact]
    public void ResponseMailByAlias()
    {
        _gmailMainPage.Navigate();
        _gmailMainPage.ClickSignIn();
        _gmailMainPage.SendUser("TTestMail444");
        _gmailMainPage.ClickNext();
        _gmailMainPage.SendPassword("x6KJgTDw2Khk4Nc");
        _gmailMainPage.ClickNext();
        _gmailMainPage.ClickAndGotoMail();
        _gmailMainPage.ClickReplyButton();
        _gmailMainPage.SelectContacts();
        _gmailMainPage.ChooseContacts("asdbbdeeetrerwerwe-Aliased@yahoo.com");
        _gmailMainPage.Response("This is response");
        _gmailMainPage.SendResponse();
    }
}

public class YahooAccountTests : EmailTests
{
    public YahooAccountTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    [Fact]
    public void LoginTest()
    {
        _yahooMainPage.Navigate();
        _yahooMainPage.ClickSignIn();
        _yahooMainPage.SendUser("TTestMail44");
        _yahooMainPage.ClickNext();
        _yahooMainPage.SendPassword("R4E5jdEQSS7uNnF");
        _yahooMainPage.ClickNext();
        _yahooMainPage.Validate().ValidUserLogin("TestEmailYahoo");
    }

    [Fact]
    public void InvalidUsernameTest()
    {
        _yahooMainPage.Navigate();
        _yahooMainPage.ClickSignIn();
        _yahooMainPage.SendUser("-ABCD--");
        _yahooMainPage.ClickNext();
        _yahooMainPage.Validate().InvalidUserLogin();
    }

    [Fact]
    public void InvalidPasswordTest()
    {
        _yahooMainPage.Navigate();
        _yahooMainPage.ClickSignIn();
        _yahooMainPage.SendUser("TTestMail44");
        _yahooMainPage.ClickNext();
        _yahooMainPage.SendPassword("abcd");
        _yahooMainPage.ClickNext();
        _yahooMainPage.Validate().InvalidUserPassword();
    }

    [Fact]
    public void SendMail()
    {
        _yahooMainPage.Navigate();
        _yahooMainPage.ClickSignIn();
        _yahooMainPage.SendUser("TTestMail44");
        _yahooMainPage.ClickNext();
        _yahooMainPage.SendPassword("R4E5jdEQSS7uNnF");
        _yahooMainPage.ClickNext();
        _yahooMainPage.ClickMail();
        _yahooMainPage.ClickCompose();
        _yahooMainPage.MailTarget("TTestMail444@gmail.com");
        _yahooMainPage.MailSubject("Test mail");
        _yahooMainPage.MailContent("Test mail from yahoo");
        _yahooMainPage.SendMail();
    }

    [Fact]
    public void MailUnreadCheck()
    {
        _yahooMainPage.Navigate();
        _yahooMainPage.ClickSignIn();
        _yahooMainPage.SendUser("TTestMail44");
        _yahooMainPage.ClickNext();
        _yahooMainPage.SendPassword("R4E5jdEQSS7uNnF");
        _yahooMainPage.ClickNext();
        _yahooMainPage.GoToProfile();
        Driver.SwitchTo().Window(Driver.WindowHandles[1]);
        _yahooMainPage.EditProfile();
        _yahooMainPage.Changenickname("NewNickName");
        _yahooMainPage.Validate().ValidateNickname("NewNickName");
    }
}