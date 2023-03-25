using OpenQA.Selenium;
using WDH;
using WDH.GoogleCloud;
using Xunit.Abstractions;

namespace Tests;

public class CloudTests : IDisposable
{
    public ITestOutputHelper _testOutputHelper;

    public CloudWorker cloudMainPage;
    public MailWorker mailMainPage;
    public ScreenshotHandler screenshotHandler;
    public TestLogger Logger;

    public CloudTests(ITestOutputHelper testOutputHelper)
    {   
        _testOutputHelper = testOutputHelper;

        try
        {
            Initializer.BrowserSelector("chrome");
        }
        catch (NotFoundException)
        {
            _testOutputHelper.WriteLine("Selected browser was not found");
            throw;
        }

        Logger = new TestLogger(Initializer.Driver);
        screenshotHandler = new ScreenshotHandler(Initializer.Driver);
        cloudMainPage = new CloudWorker(Initializer.Driver);
        mailMainPage = new MailWorker(Initializer.Driver);
    }

    public void Dispose()
    {
        Thread.Sleep(5000);
        Initializer.Driver.Quit();
    }
}

public class GoogleCloudTests : CloudTests
{
    public GoogleCloudTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    [Fact]
    public void GoogleCloudTest()
    {
        try
        {
            cloudMainPage.Navigate();
            cloudMainPage.ClickIcon();
            cloudMainPage.ClickSearch();
            cloudMainPage.SeachValue("Google Cloud Platform Pricing Calculator");
            cloudMainPage.SubmitSeachValue();

            cloudMainPage.ClickPriceCalculator();
            cloudMainPage.ClickComputeEngine();
            cloudMainPage.SetNumberOfInstances("4");
            cloudMainPage.ClickOperatingSystem();
            cloudMainPage.ChooseOperatingSystem();

            cloudMainPage.ClickProvisioningModel();
            cloudMainPage.ChooseProvisioningModel();
            cloudMainPage.ClickMachineType();
            cloudMainPage.ChooseMachineType();
            cloudMainPage.ClickAddGPU();

            cloudMainPage.ClickGPUtype();
            cloudMainPage.ChooseGPUtype();
            cloudMainPage.ClickNumberOfGPUs();
            cloudMainPage.ChooseNumberOfGPUs();
            cloudMainPage.ClickLocalSSD();

            cloudMainPage.ChooseLocalSSD();
            cloudMainPage.ClickDatacenterLocation();
            cloudMainPage.ChooseDatacenterLocation();
            cloudMainPage.ClickAddEstimate();
            cloudMainPage.ClickEmailEstimate();

            mailMainPage.Navigate();
            mailMainPage.GenerateMail();
            mailMainPage.CopyMail();
            cloudMainPage.ClickEmailAddressField();
            cloudMainPage.PasteMail();
            cloudMainPage.SendMail();

            //wait for mail
            Thread.Sleep(5000);
            mailMainPage.GotoInbox();
            mailMainPage.Validate().ValidEstimatedCost("USD 3,649.97");
        }
        catch (Exception ex)
        {
            screenshotHandler.TakeScreenshots();
            Logger.LogError(ex.ToString());
            throw;
        }
    }
}