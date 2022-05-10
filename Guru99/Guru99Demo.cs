using Microsoft.Graph;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99
{
    class Guru99Demo
    {
       IWebDriver driver;
        

        [OneTimeSetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\chromedriver");
        }

        [Test]
        public void test1 ()
        {
            driver.Url = "https://lx-onb-recon-ui.web.app/auth";
        }

       [Test]
        public void signUpDemo()
        {
            driver.Url = "https://lx-onb-recon-ui.web.app/auth";
            driver.Manage().Window.Maximize();
            IWebElement signUpButton = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/button"));
            signUpButton.Click();

             System.Threading.Thread.Sleep(1000);
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            
            // Store locator values of email text box and sign up button
            IWebElement emailTextBox = driver.FindElement(By.XPath("//*[@id='identifierId']"));
            IWebElement nextButton = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button/div[3]"));

            
                emailTextBox.SendKeys("stanislau.mandryk@leverx.com");
                nextButton.Click();

        }

        //[Test]
        //public void emailDemo()
        //{
        //    driver.Url = "http://demo.guru99.com/test/guru99home/";
        //    driver.Manage().Window.Maximize();

        //    // Store locator values of email test box and sign up button
        //    IWebElement signUpButton = driver.FindElement(By.XPath(".contained__U3XKS.primary__cEXk4]"));

        //    emailTextBox.SendKeys("test123@gmail.com");
        //    signUpButton.Click();
        //}

        //[Test]
        //public void textBoxDemo()
        //{
        //    driver.Url = "http://demo.guru99.com/test/guru99home/";
        //    driver.Manage().Window.Maximize();

        //    // Store locator values of email text box and sign up button
        //    IWebElement emailTextBox = driver.FindElement(By.CssSelector("input[id='philadelphia-field-email']"));
        //    IWebElement signUpButton = driver.FindElement(By.CssSelector("button[id=philadelphia-field-submit]"));


        //    emailTextBox.SendKeys("test123@gmail.com");
        //    signUpButton.Click();

        //    var alert = driver.SwitchTo().Alert();
        //    Assert.AreEqual("Form Submitted Successfully...", alert.Text);

        //    driver.SwitchTo().Alert().Accept();
        //}

        //[Test]
        //public void testDdl()
        //{
        //    driver.Url = "http://demo.guru99.com/test/guru99home/";
        //    driver.Manage().Window.Maximize();

        //    IWebElement course = driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

        //    var selectTest = new SelectElement(course);
        //    // Select a value fron the dropdown
        //    selectTest.SelectByValue("sap-abap");
        //}

        //[OneTimeTearDown]
        //public void closeBrowser ()
        //{
        //    driver.Close();
        //}
    }
}
