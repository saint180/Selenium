using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class TestCase1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
                driver.Manage().Window.Maximize();

                IWebElement fnameInput = driver.FindElement(By.XPath("//label[contains(text(), 'First Name')]/following::input[1]"));
                fnameInput.SendKeys("Sachin");

                IWebElement lnameInput = driver.FindElement(By.XPath("//label[contains(text(), 'Last Name')]/following::input[1]"));
                lnameInput.SendKeys("K");

                IWebElement emailInput = driver.FindElement(By.XPath("//label[contains(text(), 'Email')]/following::input[1]"));
                emailInput.SendKeys("sachin9820246@gmail.com");

                emailInput.Submit();

                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test Failed: " + e.Message);
            }
            finally
            {
                //driver.Quit();
            }
        }
    }
}