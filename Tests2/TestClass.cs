
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tests2.BaseClass;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Tests2
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        //[Test, Category("Smoke Testing")]
        //public void TestMethodClick()
        //{
        //    IWebElement button = driver.FindElement(By.ClassName("hide-for-large")); // locate the button, can be done with any other selector
        //    Actions action = new Actions(driver);
        //    action.MoveToElement(button).Perform(); // move to the button
        //    button.Click();
        //}
        //ניתן להוסיף קטגוריה ולאחר מכן שם לזיהוי 
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement userName = driver.FindElement(By.XPath(".//*[@name='fullname']"));
            userName.SendKeys("da da da");
        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement userPhone = driver.FindElement(By.XPath(".//*[@name='phone']"));
            userPhone.SendKeys("da da da");
            IWebElement userProfessionDropdownList = driver.FindElement(By.XPath(".//*[@name='subject']"));
            SelectElement element = new SelectElement(userProfessionDropdownList);
           // element.SelectByIndex(4);
           // element.SelectByText("הנדסת תוכנה כולל התמחות בסייבר");
            element.SelectByValue("הנדסת חשמל");
            /*
            ניתן לבחור בדרופ דאון ליסט לפי 3 פרמטרים
            אינדקס, טקסט, וואליו 
            יש להוסיף את הספריה 
            using OpenQA.Selenium.Support.UI;
            */
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement userEmail = driver.FindElement(By.XPath(".//*[@name='email']"));
            userEmail.SendKeys("da da da");
            
        }
        [Test ,Category("Hover Testing")]
        public void HoverTesting()
        {
            IWebElement hover = driver.FindElement(By.Id(""));
            IWebElement subhover = driver.FindElement(By.Id(""));

        }
    }
}
