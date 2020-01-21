
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tests2.BaseClass;
using OpenQA.Selenium.Support.UI;
using Tests2.Utilities;


namespace Tests2
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;
        //ניתן להוסיף קטגוריה בתוך קטגוריה וליצור ילודה ולאחר מכן שם לזיהוי 
       [Test,Category("UAT Testing"),Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement userName = Driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
            Driver.Close(); // בהורשה כזאת חייב לסגור את הפונקציה אחרת זה רץ ברקע
        }

        /// <summary>
        /// //  נוסיף כמות טסטים רצוים שירצו במקביל לא נשכח להוסיף
        /// שתי שורות קוד בקובץ האסמבלי מצד ימין  אחרת זה לא ירוץ
        
       /// / To define [Test] attributes
        //[assembly : Parallelizable(ParallelScope.Children)]

        // Number of browsers
        //[assembly : LevelOfParallelism(4)]
        /// </summary>

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement userName = Driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
            Driver.Close(); // בהורשה כזאת חייב לסגור את הפונקציה אחרת זה רץ ברקע
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement userName = Driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
            Driver.Close(); // בהורשה כזאת חייב לסגור את הפונקציה אחרת זה רץ ברקע
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement userName = Driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
            Driver.Close(); // בהורשה כזאת חייב לסגור את הפונקציה אחרת זה רץ ברקע
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement userName = Driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
            Driver.Close(); // בהורשה כזאת חייב לסגור את הפונקציה אחרת זה רץ ברקע
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement userName = Driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
            Driver.Close(); // בהורשה כזאת חייב לסגור את הפונקציה אחרת זה רץ ברקע
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement userName = Driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
            Driver.Close(); // בהורשה כזאת חייב לסגור את הפונקציה אחרת זה רץ ברקע
        }
    }
}
