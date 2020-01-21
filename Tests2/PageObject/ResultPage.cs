using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests2.PageObject
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver) // ניצור קונסטרקטור להעתקת המשתנה המאותחל
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this); //  שיתוף כל האלמנטים שנמצאו מהקלאס הנוכחי
        }
        [FindsBy(How = How.LinkText, Using = "Selenium C# Page Object Model by Bakkappa N")]
        public IWebElement ChannelNameLinkText { get; set; } // prop ->  מתודה בנויה 


        // יש הבדל בין החיפוש הזה לקודם 
        //נשים לב שהחיפוש התבצע לפי איי דיי אבל בתוספת השניה 
        // החיפוש היה לפי לינקטקסט ולכן החלפנו את החיפוש לפי 
        //LinkText


        public ChannelPage NavigateToChannelPage()
        {
            // ניצור מתודה שמקבלת את האלמנטים מהקלאס ועושה עליהם פעולות
            Thread.Sleep(3000);
            ChannelNameLinkText.Click();
            return new ChannelPage(driver); // מחזיר את המיקום של הכתובת יו אר אל
        }
    }
}

