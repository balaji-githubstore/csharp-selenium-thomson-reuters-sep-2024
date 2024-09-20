using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumConceptUnitTestProject
{
    public class Demo3FrameTest
    {
        /// <summary>
        /// Switch to frame using IWebElement
        /// </summary>
        [Test]
        public void HdfcFrameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";


            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //enter userid as john123
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("john123");
            
            //click on continue
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            driver.FindElement(By.Id("fldPasswordDispId")).SendKeys("welcome123");
            //driver.ExecuteJavaScript("document.querySelector('#keyboard').value='kkkkk'");

            driver.FindElement(By.PartialLinkText("LOGIN")).Click();

            string actualAlertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();

            driver.SwitchTo().DefaultContent();
        }
    }
}
