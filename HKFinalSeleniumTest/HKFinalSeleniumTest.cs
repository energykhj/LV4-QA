/*
 ROG2070-QA Final Exam - Selenium Test
 Created by: Heejin Ko(Sec2)
 Revision History:
         Heuijin Ko, 4/20/2020 : Created
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

namespace HKFinalSeleniumTest
{
    /// <summary>
    /// Class of the test
    /// </summary>
    [TestFixture]
    public class HKFinalSeleniumTest
    {
        private IWebDriver driver;

        IWebElement vx;
        IWebElement vy;
        IWebElement vz;
        IWebElement va;
        IWebElement vb;
        IWebElement vc;

        IWebElement cal;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            string HomeURL = "https://www.calculator.net/triangle-calculator.html";
            driver.Navigate().GoToUrl(HomeURL);

            // side
            va = driver.FindElement(By.Name("va"));
            vb = driver.FindElement(By.Name("vb"));
            vc = driver.FindElement(By.Name("vc"));

            vx = driver.FindElement(By.Name("vx"));
            vy = driver.FindElement(By.Name("vy"));
            vz = driver.FindElement(By.Name("vz"));

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
        /// tester: khj
        /// InValid_Value
        /// </summary>
        [Test]
        public void Final_InValid_Value_returnError()
        {
            va.Clear();
            va.SendKeys("20");
            vb.Clear();
            vb.SendKeys("20");
            vc.Clear();
            vc.SendKeys("20");

            driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td/table/tbody/tr[5]/td/input")).Click();

            string txt = driver.FindElement(By.XPath(".//*[@id='content']/p[2]/font")).Text.Trim();

            Assert.AreEqual("Please provide three positive values only. You have 5 now.", txt);
        }

        /// <summary>
        /// Tester: khj
        /// EquilateralTriangl
        /// </summary>
        [Test]
        public void Final_60_60_60_EquilateralTriangle()
        {
            va.Clear();
            va.SendKeys("60");
            vb.Clear();
            vb.SendKeys("60");
            vc.Clear();
            vc.SendKeys("60");
            vx.Clear();

            driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td/table/tbody/tr[5]/td/input")).Click();

            string txt = driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td[1]/h3")).Text.Trim();

            Assert.AreEqual("Equilateral Triangle", txt);
        }

        /// <summary>
        /// tester: khj
        /// AcuteIsoscelesTriangle
        /// </summary>
        [Test]
        public void Final_AcuteIsoscelesTriangle()
        {
            vx.Clear();
            vx.SendKeys("30");
            vy.Clear();
            vz.Clear();
            va.SendKeys("80");
            vb.Clear();
            vb.SendKeys("80");
            vc.Clear();
            vc.SendKeys("20");


            driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td/table/tbody/tr[5]/td/input")).Click();

            string txt = driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td[1]/h3")).Text.Trim();

            Assert.AreEqual("Acute Isosceles Triangle", txt);
        }


        /// <summary>
        /// tester: khj
        /// under 180
        /// </summary>
        [Test]
        public void Final_Under_180_returnError()
        {
            vx.Clear();
            vx.SendKeys("30");
            vy.Clear();
            vz.Clear();
            va.SendKeys("80");
            vb.Clear();
            vb.SendKeys("40");
            vc.Clear();
            vc.SendKeys("20");


            driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td/table/tbody/tr[5]/td/input")).Click();

            string txt = driver.FindElement(By.XPath(".//*[@id='content']/p[2]/font")).Text.Trim();

            Assert.AreEqual("The sum of the three angles must equal 180° or π radians.", txt);
        }

        /// <summary>
        /// tester: khj
        /// "Acute Scalene Triangle
        /// </summary>
        [Test]
        public void Final_80_40_60_AcuteScaleneTriangle()
        {
            vx.Clear();
            vx.SendKeys("30");
            vy.Clear();
            vz.Clear();
            va.SendKeys("80");
            vb.Clear();
            vb.SendKeys("40");
            vc.Clear();
            vc.SendKeys("60");


            driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td/table/tbody/tr[5]/td/input")).Click();

            string txt = driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr/td[1]/h3")).Text.Trim();

            Assert.AreEqual("Acute Scalene Triangle", txt);
        }
    }


}