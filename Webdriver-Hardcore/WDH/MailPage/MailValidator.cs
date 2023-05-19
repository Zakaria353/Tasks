using OpenQA.Selenium;

namespace WDH.GoogleCloud;

public class MailValidator : Initializer
{
    public MailValidator(IWebDriver driver) : base(driver)
    {

    }

    protected MailElementMap Map
    {
        get
        {
            return new MailElementMap(_driver);
        }
    }

    public void ValidEstimatedCost(string expectedValue)
    {
        Framehandler.MailFrameHandler();
        Assert.True(Map.MailContent.Text.Contains(expectedValue), "Invalid amount");
    }
}