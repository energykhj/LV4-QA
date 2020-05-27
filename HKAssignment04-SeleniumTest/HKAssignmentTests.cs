/*
 ROG2070-QA Assignment4
 Created by: Heejin Ko(Sec2)
 Revision History:
         Heejin Ko, 4/10/2020 : Created
                    4/13/2020 : Updated
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace HKAssignment04
{
    /// <summary>
    /// Class of the test
    /// </summary>
    [TestFixture]
    public class HKAssignmentTests
    {
        private IWebDriver driver;

        IWebElement SellerName;
        IWebElement Address;
        IWebElement City;
        IWebElement Phone;
        IWebElement Email;
        IWebElement Make;
        IWebElement Model;
        IWebElement Year;
        IWebElement Save;

        /// <summary>
        /// Instantiating IWebDriver as a Firefox driver
        /// Drivers for other browsers are available, too
        /// </summary>
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            string HomeURL = "http://localhost:63342/HKAssignment04Html/index.html?_ijt=3oopvnqg8k2tj989jclrs3ofcj";
            driver.Navigate().GoToUrl(HomeURL);

            SellerName = driver.FindElement(By.Id("txtSellerName"));
            Address = driver.FindElement(By.Id("txtAddress"));
            City = driver.FindElement(By.Id("txtCity"));
            Phone = driver.FindElement(By.Id("txtPhone"));
            Email = driver.FindElement(By.Id("txtEmail"));
            Make = driver.FindElement(By.Id("txtMake"));
            Model = driver.FindElement(By.Id("txtModel"));
            Year = driver.FindElement(By.Id("txtYear"));
            Save = driver.FindElement(By.Id("btnSave"));
        }

        /// <summary>
        /// The method of quit a WebDriver
        /// </summary>
        [TearDown]
        public void TearDownWebDriver()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Tester: khj
        /// Validation check 
        /// when SellerName field is empty, return error
        /// </summary>
        [Test]
        public void TestA4_Validate_NoSellerName_returnError()
        {
            SellerName.Clear();
            Address.Clear();
            Address.SendKeys("229 Doon");
            City.Clear();
            City.SendKeys("Kitchener");
            Phone.Clear();
            Phone.SendKeys("111-222-3333");
            Email.Clear();
            Email.SendKeys("test@t.c");
            Make.Clear();
            Make.SendKeys("Ford");
            Model.Clear();
            Model.SendKeys("Mustang");
            Year.Clear();
            Year.SendKeys("2012");
            Save.Click();

            string error = driver.FindElement(By.Id("txtSellerName-error")).Text;

            Assert.AreEqual("Seller name is required", error);
        }

        /// <summary>
        /// Tester: khj
        /// Validation check 
        /// when Address field is empty, return error
        /// </summary>
        [Test]
        public void TestA4_Validate_NoAddress_returnError()
        {            
            SellerName.Clear();
            SellerName.SendKeys("HKo7452");
            Address.Clear();
            City.Clear();
            City.SendKeys("Kitchener");
            Phone.Clear();
            Phone.SendKeys("111-222-3333");
            Email.Clear();
            Email.SendKeys("test@t.c");
            Make.Clear();
            Make.SendKeys("Ford");
            Model.Clear();
            Model.SendKeys("Mustang");
            Year.Clear();
            Year.SendKeys("2012");
            Save.Click();

            string error = driver.FindElement(By.Id("txtAddress-error")).Text;

            Assert.AreEqual("Address is required", error);
        }

        /// <summary>
        /// Tester: khj
        /// Validation check 
        /// when Phone number field is empty, return error
        /// </summary>
        [Test]
        public void TestA4_Validate_NoPhoneNumber_returnError()
        {
            SellerName.Clear();
            SellerName.SendKeys("HKo7452");
            Address.Clear();
            Address.SendKeys("229 Doon");
            City.Clear();
            City.SendKeys("Kitchener");
            Phone.Clear();
            Email.Clear();
            Email.SendKeys("test@t.c");
            Make.Clear();
            Make.SendKeys("Ford");
            Model.Clear();
            Model.SendKeys("Mustang");
            Year.Clear();
            Year.SendKeys("2012");
            Save.Click();

            string error = driver.FindElement(By.Id("txtPhone-error")).Text;

            Assert.AreEqual("Phone number is required", error);
        }

        /// <summary>
        /// Tester: khj
        /// Validation check 
        /// when enter invalid the Phone number, return error
        /// </summary>
        [Test]
        public void TestA4_Validate_InvalidPhoneNumber_returnError()
        {
            SellerName.Clear();
            SellerName.SendKeys("HKo7452");
            Address.Clear();
            Address.SendKeys("229 Doon");
            City.Clear();
            City.SendKeys("Kitchener");
            Phone.Clear();
            Phone.SendKeys("1112223333");
            Email.Clear();
            Email.SendKeys("test@t.c");
            Make.Clear();
            Make.SendKeys("Ford");
            Model.Clear();
            Model.SendKeys("Mustang");
            Year.Clear();
            Year.SendKeys("2012");
            Save.Click();

            string error = driver.FindElement(By.Id("txtPhone-error")).Text;

            Assert.AreEqual("Please enter a valid Phone number(formats: 123-123-1234, or (123)123-1234)", error);
        }

        /// <summary>
        /// Tester: khj
        /// When all fields are valid, alert success message
        /// </summary>
        [Test]
        public void TestA4_RecordAdded_Successfully()
        {
            SellerName.Clear();
            SellerName.SendKeys("HKo7452");
            Address.Clear();
            Address.SendKeys("229 Doon");
            City.Clear();
            City.SendKeys("Kitchener");
            Phone.Clear();
            Phone.SendKeys("111-222-3333");
            Email.Clear();
            Email.SendKeys("test@t.c");
            Make.Clear();
            Make.SendKeys("Ford");
            Model.Clear();
            Model.SendKeys("Mustang");
            Year.Clear();
            Year.SendKeys("2012");
            Save.Click();
            
            IAlert alert = driver.SwitchTo().Alert();
            string txtAlert = alert.Text;

            Assert.AreEqual("Record added successfully", txtAlert);
        }

        /// <summary>
        /// Tester: khj
        /// No data in storage and when click the Search button, alert message
        /// </summary>
        [Test]
        public void TestA4_Display_All_SavedList_NoDataOnStorage()
        {
            driver.FindElement(By.Id("btnSearch")).Click();

            IAlert alert = driver.SwitchTo().Alert();
            string txtAlert = alert.Text;

            Assert.AreEqual("No data on storage", txtAlert);
        }

        /// <summary>
        /// Tester: khj
        /// Linke test
        /// </summary>
        [Test]
        public void TestA4_JDPower_LinkIsCorrect_Ford_Mustang_2012()
        {
            SellerName.Clear();
            SellerName.SendKeys("HKo7452");
            Address.Clear();
            Address.SendKeys("229 Doon");
            City.Clear();
            City.SendKeys("Kitchener");
            Phone.Clear();
            Phone.SendKeys("111-222-3333");
            Email.Clear();
            Email.SendKeys("test@t.c");
            Make.Clear();
            Make.SendKeys("Ford");
            Model.Clear();
            Model.SendKeys("Mustang");
            Year.Clear();
            Year.SendKeys("2012");
            Save.Click();

            IAlert alert = driver.SwitchTo().Alert();
            string txtAlert = alert.Text;
            if (txtAlert == "Record added successfully") driver.SwitchTo().Alert().Accept();
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            driver.FindElement(By.LinkText("JD Link")).Click();

            Assert.AreEqual("https://www.jdpower.com/cars/2012/ford/mustang/coupe-2d-boss-302", driver.Url);
        }

    }
}
