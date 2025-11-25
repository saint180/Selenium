using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public class TestCase1
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            driver.Manage().Window.Maximize();

            IWebElement fnameInput = driver.FindElement(By.Name("First Name"));
            fnameInput.SendKeys("Sachin");

            IWebElement lnameInput = driver.FindElement(By.Name("Last Name"));
            lnameInput.SendKeys("K");

            IWebElement emailInput = driver.FindElement(By.Name("Email"));
            emailInput.SendKeys("sachin9820246@gmail.com");
            emailInput.Submit();

            System.Threading.Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
