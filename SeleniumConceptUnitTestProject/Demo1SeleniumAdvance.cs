using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.SeleniumConceptUnitTestProject
{
    public class Demo1SeleniumAdvance
    {
        [Test]
        public void Demo1MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            //b[contains(text(),'phpMyAdmin')]
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            //enter password as admin123
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");

            //click on login
            driver.FindElement(By.Id("input_go")).Click();

            driver.Close(); //close the current tab 

            //switch to 1st tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            //print the title 
            Console.WriteLine(driver.Title);

            driver.Quit();
        }

        [Test]
        public void Demo2TabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //close all popup
            driver.FindElement(By.XPath("//a[@class='newclose']")).Click();
            driver.FindElement(By.XPath("//a[@class='newclose2']")).Click();

            //click on Banking
            driver.FindElement(By.LinkText("Banking")).Click();

            //click on Citi Commercial Bank
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //click on Branch/ATM
            driver.FindElement(By.LinkText("Branch/ATM")).Click();

            //Select Citibank ATM as Bengaluru - dropdown without select tag
            driver.FindElement(By.XPath("//a[text()='Choose One']")).Click();
            driver.FindElement(By.LinkText("Bengaluru")).Click();
        }
    }
}
