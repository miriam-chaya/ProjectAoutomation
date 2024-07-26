using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExample.Tests
{

    [TestFixture]
    public class GoogleSearchTest
    {
        private IWebDriver driver;

        public GoogleSearchTest()
        {

        }

        [SetUp]
        public void SetUp()
        {
            string path = "T:\\הנדסת תוכנה\\שנה ב\\קבוצה ב\\תלמידות\\חיה ויזל\\SeleniumNUnitExample\\SeleniumNUnitExample\\Drivers";

            //Creates the ChomeDriver object, Executes tests on Google Chrome

            driver = new ChromeDriver(path);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestGoogleSearch()
        {
            // Step 1: Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com"); 

            // Step 2: Verify the title of the page
            Assert.AreEqual("Google", driver.Title);

            // Step 3: Find the search box using its name attribute
            IWebElement searchBox = driver.FindElement(By.Name("q"));

            // Step 4: Enter the search term and submit the search
            searchBox.SendKeys("Selenium WebDriver");
            searchBox.Submit();
            
            Assert.AreEqual("Selenium WebDriver - חיפוש ב-Google", driver.Title);
            driver.Navigate().Back();
            

        }
        [TearDown]
        public void TearDown() 
        {
            driver.Dispose();
        }
    }
}
