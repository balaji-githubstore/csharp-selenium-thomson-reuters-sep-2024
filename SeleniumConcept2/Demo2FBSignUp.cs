using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
//facebook signup
namespace SeleniumConcept2
{
    public class Demo2FBSignUp
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.Url = "https://www.facebook.com"; //wait for page load to complete 

            //FindElement - checks for presence of locator in 0.5s
            driver.FindElement(By.LinkText("Create new account")).Click();

            //FindElement - checks for presence of locator in 0.5s
            driver.FindElement(By.Name("firstname")).SendKeys("john");

            //enter lastname as wick
            driver.FindElement(By.Name("lastname")).SendKeys("wick");

            //enter password as welcome123
            driver.FindElement(By.Id("password_step_input")).SendKeys("john");

            //17 June 1992 
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("17");

            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Jun");

            //selectMonth.SelectByValue("6");
            //selectMonth.SelectByIndex(5);

            //select year 1992
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("1992");

            //click on custom radio button
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //click on signup
        }
    }
}
