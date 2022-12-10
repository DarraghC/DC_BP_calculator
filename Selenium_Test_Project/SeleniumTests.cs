using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace Selenium_Test_Project
{
    public class Selenium_Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            String chromeDriverPath = Environment.GetEnvironmentVariable("ChromeWebDriver");
            chromeDriverPath ??= "C:\\Users\\darra\\OneDrive\\Desktop\\CSD REPO MS VS\\Selenium_Test_Project\\Drivers\\chromedriver.exe";
            driver = new ChromeDriver(chromeDriverPath);         
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestBpCalculatorIdealPressure()
        {

            // web app running on IIS express
            driver.Navigate().GoToUrl("http://localhost:53135/");

            // get Bp_Systolic
            IWebElement SystolicElement = driver.FindElement(By.Id("Bp_Systolic"));
            SystolicElement.SendKeys("100");

            // get Bp_Diastolic
            IWebElement DiastolicElement = driver.FindElement(By.Id("Bp_Diastolic"));
            DiastolicElement.SendKeys("60");


            // submit the form
            driver.FindElement(By.Id("form1")).Submit();


            IWebElement BPValueElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(c => c.FindElement(By.ClassName("form-control")));


            String bp = BPValueElement.Text.ToString();

            StringAssert.EndsWith(bp, "Ideal Blood Pressure");


            // alternative - use Cypress or Playright
        }

        [Test]
        public void TestBpCalculatorLowPressure()
        {

            // web app running on IIS express
            driver.Navigate().GoToUrl("http://localhost:53135/");

            // get Bp_Systolic
            IWebElement SystolicElement = driver.FindElement(By.Id("Bp_Systolic"));
            SystolicElement.SendKeys("90");

            // get Bp_Diastolic
            IWebElement DiastolicElement = driver.FindElement(By.Id("Bp_Diastolic"));
            DiastolicElement.SendKeys("50");


            // submit the form
            driver.FindElement(By.Id("form1")).Submit();


            IWebElement BPValueElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(c => c.FindElement(By.ClassName("form-control")));


            String bp = BPValueElement.Text.ToString();

            StringAssert.EndsWith(bp, "Low Blood Pressure");


            // alternative - use Cypress or Playright
        }
    }
}