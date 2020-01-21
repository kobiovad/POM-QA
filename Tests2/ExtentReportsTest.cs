using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests2
{
        /// <summary>
        /// חובה להוסיף אץ הספריות 
        /// using AventStack.ExtentReports;
        /// using AventStack.ExtentReports.Reporter;
        /// ולהוסיף את הספריה בנוגא מנג 
        /// Extentreports -(author = anshooarora)
        /// נוסיף ספריה referernces
        /// לשמירת הדוח
        /// </summary>
    public class ExtentReportsTest
    {
        ExtentReports extent = null; // נאתחל את המשתנה 

        [OneTimeSetUp]
        public void ExtentStart() 
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd"); // ניסיון ליצירת שם דינאמי שישמר
            extent = new ExtentReports(); // הטענת המשתנה בטמפלט
            var htmlReporter = new ExtentHtmlReporter(@"C:\\Users\\Kobi\\source\\repos\\SeleniumCsharpTest\\Tests2\\ExtentReport\\Er-"+date +".html");
            extent.AttachReporter(htmlReporter);    
        }
        [OneTimeTearDown]
        public void ExtentFinish()
        {
            extent.Flush();// סגירה של הדוח
        }

        [Test]
        
        public void ReportTest1()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("ReportTest1").Info("Test Start"); // נגדיר שם ותיאור לטסט
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser Lauched");// ניתן להוסיף נקודות שירשמו לעזר
                driver.Url = "https://tcb.ac.il/";
                IWebElement userNameField = driver.FindElement(By.XPath(".//*[@name='fullname']"));
                userNameField.SendKeys("Da Da Da ");
                driver.Quit();
                test.Log(Status.Pass, "ReportTest1 Passed"); // אם הגענו לפה הטסט עבר בהצלחה
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());//רישום הבעיה במסוף הדוחות 
                //Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                    driver.Quit(); // סגירה סופית 
            }
        }
    }
}
