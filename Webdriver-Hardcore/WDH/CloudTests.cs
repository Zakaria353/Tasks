using OpenQA.Selenium;
using WDH;
using WDH.GoogleCloud;
using Xunit.Abstractions;

namespace Tests;

public class CloudTests : IDisposable
{
    public ITestOutputHelper _testOutputHelper;

    public CloudWorker cloudPage;
    public MailWorker mailPage;
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
        cloudPage = new CloudWorker(Initializer.Driver);
        mailPage = new MailWorker(Initializer.Driver);
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
            cloudPage.Navigate();
            cloudPage.ClickIcon();
            cloudPage.ClickSearch();
            cloudPage.SeachValue("Google Cloud Platform Pricing Calculator");
            cloudPage.SubmitSeachValue();

            cloudPage.ClickPriceCalculator();
            cloudPage.ClickComputeEngine();
            cloudPage.SetNumberOfInstances("4");
            cloudPage.ClickOperatingSystem();
            cloudPage.ChooseOperatingSystem();

            cloudPage.ClickProvisioningModel();
            cloudPage.ChooseProvisioningModel();
            cloudPage.ClickMachineType();
            cloudPage.ChooseMachineType();
            cloudPage.ClickAddGPU();

            cloudPage.ClickGPUtype();
            cloudPage.ChooseGPUtype();
            cloudPage.ClickNumberOfGPUs();
            cloudPage.ChooseNumberOfGPUs();
            cloudPage.ClickLocalSSD();

            cloudPage.ChooseLocalSSD();
            cloudPage.ClickDatacenterLocation();
            cloudPage.ChooseDatacenterLocation();
            cloudPage.ClickAddEstimate();
            cloudPage.ClickEmailEstimate();

            mailPage.Navigate();
            mailPage.GenerateMail();
            mailPage.CopyMail();
            cloudPage.ClickEmailAddressField();
            cloudPage.PasteMail();
            cloudPage.SendMail();

            //wait for mail
            Thread.Sleep(5000);
            mailPage.GotoInbox();
            mailPage.Validate().ValidEstimatedCost("USD 3,649.97");
        }
        catch (Exception ex)
        {
            screenshotHandler.TakeScreenshots();
            Logger.LogError(ex.ToString());
            throw;
        }
    }
}