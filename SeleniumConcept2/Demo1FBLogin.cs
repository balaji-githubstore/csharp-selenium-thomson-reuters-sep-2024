using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo1FBLogin
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();



            driver.Url = "https://www.facebook.com/";

            //By locator= By.Id("email");
            //IWebElement element= driver.FindElement(locator);
            //element.SendKeys("hello123");

            IWebElement element = driver.FindElement(By.Id("email"));
            element.SendKeys("hello123");

            //driver.FindElement(By.Id("email")).SendKeys("hello12233333333@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("welcome123");

            //click on login
            driver.FindElement(By.Name("login")).Click();
        }
    }
}
