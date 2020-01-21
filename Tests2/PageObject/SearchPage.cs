using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects; // ייבוא של הספרייה עם כל המתודות כדי למשוך ערכים מהם
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests2.PageObject
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver) // ניצור קונסטרקטור להעתקת המשתנה המאותחל
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this); // שיתוף כל האלמנטים שנמצאו
        }
        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchTextbox { get; set; } // prop ->  מתודה בנויה 

        [FindsBy(How = How.CssSelector, Using = "#search-icon-legacy")]
        public IWebElement SearchButton { get; set; } 
        // יש הבדל בין החיפוש הזה לקודם 
        //נשים לב שהחיפוש התבצע לפי איי דיי אבל בתוספת השניה 
        // החיפוש היה לפי האשטאג ולכן החלפנו את החיפוש לפי 
        //CssSelector

        public ResultPage NavigateToResultPage() 
        {
            // ניצור מתודה שמקבלת את האלמנטים מהקלאס ועושה עליהם פעולות
            SearchTextbox.SendKeys("Selenium c# by bakkappa n");
            SearchButton.Click();
            Thread.Sleep(3000);
            return new ResultPage(driver); // ברגע שעוברים בין דפים יש לדאוג שהדרייבר מאותחל נכון ולכן נחזיר אותו לפי המקום הנוכחי
        }
    }
}
