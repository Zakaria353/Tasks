using OpenQA.Selenium;
using Xunit;

namespace Webdriver.net;

public class YahooValidator : Initializer
{
    //private readonly IWebDriver _driver;

    public YahooValidator(IWebDriver driver): base(driver)
    {
        //_driver = driver;
    }

    protected YahooElementMap Map
    {
        get
        {
            return new YahooElementMap(_driver);
        }
    }

    public void ValidUserLogin(string expectedValue)
    {
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

    public void ValidateNickname(string expectedValue)
    {
        Assert.True(Map.ValidateNickname.Text.Equals(expectedValue), "Unexpected nickname");
    }
}