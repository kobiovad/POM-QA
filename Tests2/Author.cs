using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections;
using OpenQA.Selenium.Interactions;

namespace Tests2
{
    [TestFixture]
    public class Author
    {
        [Test]
        [Author(name:"Kobi Ovadia", email: "kobiovad@gmail.com")]
        [Description("Author Test --- ")]
        [TestCaseSource("DataDrivenTesting")] //נרשום בתוך המרכאות את שם הפונקציה לקריאה 
        public void Test1(string urlName) // נוסיף משתנה שישלח לפי סדר הליסט 
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://tcb.ac.il/";
                driver.Url = urlName;
                //IWebElement userNameField = driver.FindElement(By.XPath(".//*[@name='fullname']"));
                //userNameField.SendKeys("Blop Blop");
                IWebElement userNameField = driver.FindElement(By.XPath(".//*[@name='ABCD']")); // נעשה טעות בכוונה שיצלם את המסך וישמור
                driver.Quit();
            }
            catch (Exception e)
            {
                //Take Screenshot 
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Kobi\\source\\repos\\SeleniumCsharpTest\\Tests2\\ScreenShot\\blop.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                    driver.Quit();
            }
            
        }

        [Test]
        [Author(name: "Kobi Ovadia", email: "kobiovad@gmail.com")]
        [Description("Author Test --- ")]
        [TestCaseSource("DataDrivenTesting")] //נרשום בתוך המרכאות את שם הפונקציה לקריאה 
        public void HoverOnMenuTcb(string urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://tcb.ac.il/";
                driver.Url = urlName;
                IWebElement menuOpen = driver.FindElement(By.Id("menu-item-1688"));
                IWebElement afterMenuOpen = driver.FindElement(By.Id("menu-item-2243 "));
                // IWebElement seleniumWebDriver = driver.FindElement(By.Id("Selenium WebDriver"));
                Hover(driver, menuOpen); // נשלח לפונקציית הובר שני משתנים
                HoverAndClick(driver, afterMenuOpen); // חייב קודם כל לפתוח את ההובר הראשון
                driver.Quit();
            }
            catch (Exception e)
            {
                //Take Screenshot 
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                
                screenshot.SaveAsFile("C:\\Users\\Kobi\\source\\repos\\SeleniumCsharpTest\\Tests2\\ScreenShot\\blop.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                    driver.Quit();
            }
        }
        [Test]
        [Author(name: "yakov ", email: "kobiovad@gmail.com")]
        [Description("Blop Test --- ")]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://tcb.ac.il/";
            IWebElement userNameField = driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userNameField.SendKeys("Blop Blop");
            driver.Quit();

        }
        static IList DataDrivenTesting()  // נבנה פונקציה שמכילה את כל הכתובות 
        {
            ArrayList list = new ArrayList();
            list.Add("https://tcb.ac.il/");
            //list.Add("https://amazon.com/");
            //list.Add("https://google.com/");

            return list;
        }
        public void Hover(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void HoverAndClick(IWebDriver driver, IWebElement elementToClick)
        {
            Actions action = new Actions(driver);
            // action.MoveToElement(elementToHover).Click(elementToClick).Build().Perform();
            action.Click(elementToClick).Build().Perform();

        }
    }
}
