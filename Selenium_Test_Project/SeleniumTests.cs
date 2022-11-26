using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using Microsoft.VisualBasic;

namespace Selenium_Test_Project
{
    public class Selenium_Tests
    {

        [Test]
        public void TestBpCalculatorIdealPressure()
        {

            
            String chromeDriverPath = Environment.GetEnvironmentVariable("ChromeWebDriver");
            chromeDriverPath ??= "C:\\Users\\darra\\OneDrive\\Desktop\\CSD REPO MS VS\\Selenium_Test_Project\\Drivers\\chromedriver.exe";                 // for IDE

            using IWebDriver driver = new ChromeDriver(chromeDriverPath);
            // any exception below results in a test fail

            // navigate to URI for bp calculator
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

            driver.Quit();

            // alternative - use Cypress or Playright
        }
    }
}