using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept2
{
    public class Demo3SalesForce
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            //2.Enter first name as “John”
            driver.FindElement(By.Name("UserFirstName")).SendKeys("john");

            //3.Enter last name as “wick”
            
            driver.FindElement(By.XPath("//input[contains(@id,'UserLast')]")).SendKeys("wick");

            //4.Enter work email as “john @gmail.com”
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@CCCS.com");

            //5.Select Job title as “IT Manager”
            SelectElement selectJobTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectJobTitle.SelectByText("IT Manager");


            //7.Select country as “United Kingdom”
            SelectElement selectcountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectcountry.SelectByText("United Kingdom");

            //6.Select Employees as “101 - 500 employees”
            SelectElement selectEmployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployees.SelectByText("101 - 200 employees");

            //9.Click on check box
            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();

            //10.Click on start my free trial
            driver.FindElement(By.Name("start my free trial")).Click();

            //get header and print
            string actualHeader= driver.FindElement(By.TagName("h1")).Text;
            Console.WriteLine(actualHeader);

            //11.Get the error message displayed “Enter a valid phone number”
            string actualError = driver.FindElement(By.XPath("//span[contains(text(),'valid phone')]")).Text;
            Console.WriteLine(actualError);

        }
    }
}
