using OpenQA.Selenium;

namespace WDH.GoogleCloud;

public class CloudElementMap : Initializer
{
    public CloudElementMap(IWebDriver driver) : base(driver)
    {
        
    }

    public IWebElement CloudIcon
    {
        get
        {
            return _driver.FindElement(By.XPath("//a[@class='devsite-site-logo-link gc-analytics-event']/img"));
        }
    }

    public IWebElement SearchField
    {
        get
        {
            return _driver.FindElement(By.XPath("//input[@name='q']"));
        }
    }

    public IWebElement PriceCalculator
    {
        get
        {
            return _driver.FindElement(By.XPath("//div[@class='gs-title']//b[text()='Google Cloud Pricing Calculator']"));
        }
    }

    public IWebElement ComputeEngine
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='tab-item-1']/descendant::*/div/div/div/div"));
        }
    }

    public IWebElement NumberOfInstances
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@ng-model='listingCtrl.computeServer.quantity']"));
        }
    }

    public IWebElement OperatingSystem
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_value_label_85']"));
        }
    }

    public IWebElement SelectOperatingSystem
    {
        get
        {
            return _driver.FindElement(By.XPath("//md-option[@id='select_option_97']"));
        }
    }

    public IWebElement ProvisioningModel
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_value_label_86']"));
        }
    }

    public IWebElement SelectProvisioningModel
    {
        get
        {
            return _driver.FindElement(By.XPath("//div[normalize-space()='Spot (Preemptible VM)']"));
        }
    }

    public IWebElement MachineType
    {
        get
        {
            return _driver.FindElement(By.Id("select_value_label_89"));
        }
    }

    public IWebElement SelectMachineType
    {
        get
        {
            return _driver.FindElement(By.Id("select_option_431"));
        }
    }

    public IWebElement AddGPU
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@name='ComputeEngineForm']/descendant::div[normalize-space()='Add GPUs.'][1]/md-input-container/md-checkbox/div[1]"));
        }
    }

    public IWebElement GPUtype
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@placeholder='GPU type']"));
        }
    }

    public IWebElement SelectGPUtype
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_option_474'][normalize-space()='NVIDIA Tesla V100']"));
        }
    }

    public IWebElement NumberOfGPUs
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_value_label_466']"));
        }
    }

    public IWebElement SelectNumberOfGPUs
    {
        get
        {
            return _driver.FindElement(By.XPath("//md-option[@role='option'][normalize-space()='1']"));
        }
    }

    public IWebElement LocalSSD
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_426'][@placeholder='Local SSD']"));
        }
    }

    public IWebElement SelectLocalSSD
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_option_452'][normalize-space()='2x375 GB']"));
        }
    }

    public IWebElement DatacenterLocation
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_126'][@placeholder='Datacenter location']"));
        }
    }

    public IWebElement SelectDatacenterLocation
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='select_option_231']"));
        }
    }

    public IWebElement AddEstimate
    {
        get
        {
            return _driver.FindElement(By.XPath("//form[@name='ComputeEngineForm']//button[@type='button'][normalize-space()='Add to Estimate']"));
        }
    }

    public IWebElement EmailEstimate
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@id='Email Estimate']"));
        }
    }

    public IWebElement EmailAddressField
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@type='email']"));
        }
    }

    public IWebElement SendEmail
    {
        get
        {
            return _driver.FindElement(By.XPath("//*[@type='button'][normalize-space()='Send Email']"));
        }
    }
}