/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomateFacebookApp.Base
{
    //
    public class Baseclass
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //Launching chrome browser
            driver = new ChromeDriver();
            //Maximize the facebook window
            driver.Manage().Window.Maximize();
            //Get the facebook URL
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        [TearDown]
        public void TearDown()
        {
            //Close the current window
            driver.Quit();
        }
    }
}
