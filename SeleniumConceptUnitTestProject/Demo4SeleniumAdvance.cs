using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System.Collections.ObjectModel;

namespace SeleniumConceptUnitTestProject
{
    public class Demo4SeleniumAdvance
    {
        [Test]
        public void ValidDocUploadTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://smallpdf.com/pdf-to-word";

            //upload the file
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Mine\profile.pdf");
        }

        [Test]
        public void Demo1ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.myntra.com/";

            driver.FindElement(By.XPath("//span[text()='Profile']")).Click();

            driver.FindElement(By.XPath("//a[text()='login / Signup']")).Click();


        }

        [Test]
        public void Demo2ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.myntra.com/";

            //driver.FindElement(By.XPath("//a[text()='Men']")).Click();
            //only mouse over works on //a[text()='Men']

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Men']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='T-Shirts']")).Click();


        }

        [Test]
        public void Demo3ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://futureskillsprime.in/";


            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Explore']"))).Perform();

            //mouse over on FutureSkills Prime
            actions.MoveToElement(driver.FindElement(By.XPath("//*[text()='FutureSkills Prime']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();

        }

        [Test]
        public void Demo4ActionsTest()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://google.com";

            Actions actions = new Actions(driver);

            actions.KeyDown(Keys.Shift).SendKeys("hello world").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.Enter)
                .Perform();

        }

        [Test]
        public void Demo5CssSelector()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://demo.openemr.io/b/openemr";

            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.CssSelector("input[name='clearPass']")).SendKeys("pass");

            driver.FindElement(By.CssSelector("[type='submit']")).Click();
        }

        [Test]
        public void Demo6JS()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";

            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();

            //approach 1 - not working
            //driver.FindElement(By.XPath("//input[@name='dateDeparture']")).SendKeys("01 Oct 2024");

            //approach 2 - automate the date calendar

            //approach 3- javascript
            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateDeparture']\").value='01 Oct 2024'");

            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateReturn']\").value='11 Oct 2024'");
        }

        [Test]
        public void Demo7JSWebElement()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";

            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();

            //approach 1 - not working
            //driver.FindElement(By.XPath("//input[@name='dateDeparture']")).SendKeys("01 Oct 2024");

            //approach 2 - automate the date calendar

            //approach 3- javascript
            IWebElement eleDepature= driver.FindElement(By.XPath("//input[@name='dateDeparture']"));
            driver.ExecuteJavaScript("arguments[0].value='01 Oct 2024'", eleDepature);


            IWebElement eleReturn = driver.FindElement(By.XPath("//input[@name='dateReturn']"));
            driver.ExecuteJavaScript("arguments[0].value='11 Oct 2024'", eleReturn);
        }


        [Test]
        public void Demo8FindElements()
        {

            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //driver.Url = "https://google.com";

            //ReadOnlyCollection<IWebElement> elementList = driver.FindElements(By.TagName("a"));

            var a = 10; //var - datatype will be decided during compile time //a is reserved for int 
            a = 20;

            var b = "hello"; //b is reserved for string
            b = "fdfdf";

            dynamic c = "sfsff"; //dynamic - datatype will be decided during run time
            c = 44;
            c = 445.44;

        }


        [Test]
        public void Demo9FindElements()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://google.com";

            ReadOnlyCollection<IWebElement> elementList = driver.FindElements(By.TagName("a"));

            Console.WriteLine(elementList.Count);

            var elementList1 = driver.FindElements(By.TagName("a")); // elementList1 is ReadOnlyCollection<IWebElement>

            var title=driver.Title; //title is string

            var res= Math.Max(89, 38.4); //res is double 




        }

        [Test]
        public void Demo10FindElements()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://google.com";

            ReadOnlyCollection<IWebElement> elementList = driver.FindElements(By.TagName("a"));

            Console.WriteLine(elementList.Count);

            elementList[0].Click();

        }

    }
}