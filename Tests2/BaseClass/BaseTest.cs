using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests2.BaseClass
{

    public class BaseTest // חייב שהקלאס יהיה פומבי כדי שיהיה אפשר לרשת ממנו
    {
        public IWebDriver driver;

        //[OneTimeSetUp] //[SetUp] 
        [SetUp]
        // ההבדל בינהם שוואן טיים פותח פעם אחת ורץ על כל הטסטים
        // שלעומת זאת רק סאטאפ פותח כל טסט בנפרד אותו הדבר עם הסגירה
        
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.youtube.com/";

        }
        
        //[OneTimeTearDown] // [TearDown] 
        [TearDown]
        public void Close()
        {
            Thread.Sleep(3000); // השהייה לפני סגירה
            driver.Close();
        }

    }
}
