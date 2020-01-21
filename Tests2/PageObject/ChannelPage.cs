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
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver) // ניצור קונסטרקטור להעתקת המשתנה המאותחל
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this); //  שיתוף כל האלמנטים שנמצאו מהקלאס הנוכחי
        }
        [FindsBy(How = How.XPath, Using = "//yt-formatted-string[contains(text(),'Selenium C# Page Object Model by Bakkappa N')]")]
        public IWebElement ChannelName { get; set; } // prop ->  מתודה בנויה 


        public string getChannelName()
        {
            return ChannelName.Text;

        }      
    }
}
