using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Remote.DesiredCapabilities;


namespace Demo
{
    [TestClass]
    public class UnitTest2
    {


        public RemoteWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            ////RemoteWebDriver driver;
            ////DesiredCapabilities capability = DesiredCapabilities.Chrome();
            ////capability.setBrowserName("chrome");
            ////capability.setPlatform(Platform.XP);

            //driver = new RemoteWebDriver(new URL(),capability);
            DesiredCapabilities Capabilities = new DesiredCapabilities();
            Capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            string GridURL = "http://10.199.82.169:4444/wd/hub";
            //Driver = new RemoteWebDriver(new Uri(GridURL), Capabilities);
            driver = new RemoteWebDriver(new Uri("http://10.199.82.169:4444/wd/hub"), Capabilities);

        }


        [TestMethod]
        public void Sum()
        {
            // IWebDriver driver = new ChromeDriver(@"C:\Selenium");
            driver.Navigate().GoToUrl("http://automatetheplanet.com/");



        }



        [TestCleanup]
        public void Cleanip()
        {
            driver.Quit();
        }
    }
    
    }
