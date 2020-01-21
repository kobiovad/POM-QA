using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;



namespace Tests2
{
    public class OrderSkipAttribute
    {/// <summary>
    /// כדי לעבוד עם דפדפנים שונים יש לייבא ברפרנס  -> נוגט מאנג 
    /// Selenium.ChromeDriver
    /// Selenium.Fireox.WebDriver
    /// Selenium.InternetExplorerDriver
    /// ולא לשכוח להוסיף את הספריות הרלוונטיות למעלה
    /// using OpenQA.Selenium.Chrome;
    /// using OpenQA.Selenium.Firefox;
    /// using OpenQA.Selenium.IE;
    /// </summary>
        [Test,Order(2), Category("OrderSkipAttribute"),Category("Cheak Browsers")]
        public void OpenChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://tcb.ac.il/";
            IWebElement userNameField = driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userNameField.SendKeys("da da da ");
            Thread.Sleep(3000);
            driver.Close();
        }
        // ניתן להוסיף את המילה אורדר באנגלית ובסגוריים את המספר  תעדוף מ-0 והלאה וככה לקבוע תעדוף בבדיקה 
        // [Test, Order(0)]

        [Test, Order(0), Category("OrderSkipAttribute"), Category("Cheak Browsers")]
        public void OpenFirefox()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://tcb.ac.il/";
            IWebElement userNameField = driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userNameField.SendKeys("da da da ");
            Thread.Sleep(3000);
            driver.Close();
        }
        [Test, Order(1), Category("OrderSkipAttribute"), Category("Cheak Browsers")]
        public void OpenInternetExplorer()
        {
            Assert.Ignore("Not Working Well"); // כאשר נוסיף את המילה אסרט באנגלית נגרום לטסט לדלג על הבדיקה הזאת
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://tcb.ac.il/";
            driver.Manage().Window.Maximize();
            IWebElement userNameField = driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userNameField.SendKeys("da da da ");
            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
