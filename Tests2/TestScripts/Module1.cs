using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tests2.BaseClass;
using Tests2.PageObject;// ייבוא של הספרייה עם כל המתודות ליצירת קשר והעברת משתנים
using OpenQA.Selenium.Support.PageObjects;


namespace Tests2.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest // הורשה ע"י ייבוא התקיה 
    {
        [Test]
        public void TestYouTube()
        {
            
            var searchbox = new SearchPage(driver);  
            var resultPage = searchbox.NavigateToResultPage();
            var channelPage = resultPage.NavigateToChannelPage();

            string actualChannelName = channelPage.getChannelName();
            string expectedChannelName = "Selenium C# Page Object Model by Bakkappa N";
            Assert.IsTrue(actualChannelName.Equals(expectedChannelName));
         
            
            Thread.Sleep(3000);

        }
    }
}
