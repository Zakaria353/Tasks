using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace WDH.GoogleCloud;

public class CloudWorker : Initializer
{
    private readonly string url = "https://cloud.google.com";

    public CloudWorker(IWebDriver driver) : base(driver)
    {
        
    }

    protected CloudElementMap Map
    {   
        get
        {
            return new CloudElementMap(_driver);
        }
    }

    public CloudValidator Validate()
    {   
        return new CloudValidator(_driver);
    }

    public CloudWorker Navigate()
    {
        _driver.Navigate().GoToUrl(url);
        return this;
    }

    public CloudWorker ClickIcon()
    {
        Map.CloudIcon.Click();
        return this;
    }

    public CloudWorker ClickSearch()
    {
        Map.SearchField.Click();
        return this;
    }

    public CloudWorker SeachValue(string searchText)
    {
        Map.SearchField.SendKeys(searchText);
        return this;
    }

    public CloudWorker SubmitSeachValue()
    {
        Map.SearchField.Submit();
        return this;
    }

    public CloudWorker ClickPriceCalculator()
    {
        Wait.Until(e => e.FindElement(By.XPath("//div[@class='gs-title']//b[text()='Google Cloud Pricing Calculator']")));
        Map.PriceCalculator.Click();
        return this;
    }
    
    public CloudWorker ClickComputeEngine()
    {
        Framehandler.CloudFrameHandler();
        Map.ComputeEngine.Click();
        return this;
    }

    public CloudWorker SetNumberOfInstances(string instances)
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@ng-model='listingCtrl.computeServer.quantity']")));
        Map.NumberOfInstances.Click();
        Map.NumberOfInstances.SendKeys(instances);
        return this;
    }

    public CloudWorker ClickOperatingSystem()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@id='select_value_label_85']")));
        Map.OperatingSystem.Click();
        return this;
    }

    public CloudWorker ChooseOperatingSystem()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//md-option[@id='select_option_97']")));
        Map.SelectOperatingSystem.Click();
        return this;
    }

    public CloudWorker ClickProvisioningModel()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@id='select_value_label_86']")));
        Map.ProvisioningModel.Click();
        return this;
    }

    public CloudWorker ChooseProvisioningModel()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[normalize-space()='Spot (Preemptible VM)']")));
        Map.SelectProvisioningModel.Click();
        return this;
    }

    public CloudWorker ClickMachineType()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("select_value_label_89")));
        Map.MachineType.Click();
        return this;
    }

    public CloudWorker ChooseMachineType()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("select_option_431")));
        Map.SelectMachineType.Click();
        return this;
    }

    public CloudWorker ClickAddGPU()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@name='ComputeEngineForm']/descendant::div[normalize-space()='Add GPUs.'][1]/md-input-container/md-checkbox/div[1]")));
        Map.AddGPU.Click();
        return this;
    }

    public CloudWorker ClickGPUtype()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@placeholder='GPU type']")));
        Map.GPUtype.Click();
        return this;
    }

    public CloudWorker ChooseGPUtype()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='select_option_474'][normalize-space()='NVIDIA Tesla V100']")));
        Map.SelectGPUtype.Click();
        return this;
    }

    public CloudWorker ClickNumberOfGPUs()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@id='select_value_label_466']")));
        Map.NumberOfGPUs.Click();
        return this;
    }

    public CloudWorker ChooseNumberOfGPUs()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//md-option[@role='option'][normalize-space()='1']")));
        Map.SelectNumberOfGPUs.Click();
        return this;
    }

    public CloudWorker ClickLocalSSD()
    {
        Wait.Until(e => e.FindElement(By.XPath("//*[@id='select_426'][@placeholder='Local SSD']")));
        Map.LocalSSD.Click();
        return this;
    }

    public CloudWorker ChooseLocalSSD()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='select_option_452'][normalize-space()='2x375 GB']")));
        Map.SelectLocalSSD.Click();
        return this;
    }

    public CloudWorker ClickDatacenterLocation()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='select_126'][@placeholder='Datacenter location']")));
        Map.DatacenterLocation.Click();
        return this;
    }

    public CloudWorker ChooseDatacenterLocation()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='select_option_231']")));
        Map.SelectDatacenterLocation.Click();
        return this;
    }

    public CloudWorker ClickAddEstimate()
    {
        Wait.Until(ExpectedConditions.ElementExists(By.XPath("//form[@name='ComputeEngineForm']//button[@type='button'][normalize-space()='Add to Estimate']")));
        Map.AddEstimate.Click();
        return this;
    }

    public CloudWorker ClickEmailEstimate()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='Email Estimate']")));
        Map.EmailEstimate.Click();
        return this;
    }

    public CloudWorker ClickEmailAddressField()
    {
        Framehandler.CloudFrameHandler();
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@type='email']")));
        IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
        ex.ExecuteScript("arguments[0].click()", Map.EmailAddressField);
        return this;
    }
    
    public CloudWorker PasteMail()
    {   
        Map.EmailAddressField.SendKeys(Keys.Control + "v");
        return this;
    }

    public CloudWorker SendMail()
    {
        Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@type='button'][normalize-space()='Send Email']")));
        Map.SendEmail.Click();
        return this;
    }
}