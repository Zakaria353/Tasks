using OpenQA.Selenium;

namespace WDH.GoogleCloud;

public class CloudValidator : Initializer
{
    public CloudValidator(IWebDriver driver) : base(driver)
    {

    }

    protected CloudElementMap Map
    {
        get
        {
            return new CloudElementMap(_driver);
        }
    }
    //assert functions here
}