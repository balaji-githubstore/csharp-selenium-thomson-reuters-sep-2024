using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConceptUnitTestProject
{
    public class Demo2Test
    {
        [Test]
        public void AlertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            
            //to inspect--> f12 or ctrl+shift+c
            //click on Go
            //driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.IgnoreExceptionTypes(typeof(Exception));
            wait.Timeout=TimeSpan.FromSeconds(20);
            wait.Until(x => x.SwitchTo().Alert());

            //wait for alert present //explicit or fluent wait
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void Assignment1Test()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.db4free.net/phpMyAdmin/";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//input[@id='input_username']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@name='pma_password']")).SendKeys("admin123");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Click();

            string actualError = driver.FindElement(By.XPath("//div[contains(text(),'Access denied for')]")).Text;
            Console.WriteLine("Error Message is " + actualError);


        }

        [Test]
        public void Assignment2Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.db4free.net/phpMyAdmin/";


            //driver.FindElement(By.XPath("//input[@id='input_username']")).SendKeys("admin");
            //driver.FindElement(By.XPath("//input[@name='pma_password']")).SendKeys("admin123");
            //driver.FindElement(By.XPath("//input[@value='Log in']")).Click();

            //string actualError = driver.FindElement(By.XPath("//div[contains(text(),'Access denied for')]")).Text;
            //Console.WriteLine("Error Message is " + actualError);

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.IgnoreExceptionTypes(typeof(Exception));
            wait.Timeout = TimeSpan.FromSeconds(20);

            wait.Until(x => x.FindElement(By.XPath("//input[@id='input_username']"))).SendKeys("jack");
            wait.Until(x => x.FindElement(By.XPath("//input[@name='pma_password']"))).SendKeys("jack");
            wait.Until(x => x.FindElement(By.XPath("//input[@value='Log in']"))).Click();

            string actualTitle = wait.Until(x => x.Title);


            string actualError =wait.Until(x => x.FindElement(By.XPath("//div[contains(text(),'Access denied for')]"))).Text;
            Console.WriteLine("Error Message is " + actualError);
        }
    }
}
