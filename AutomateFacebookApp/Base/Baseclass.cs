/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
*/
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AutomateFacebookApp.Base
{
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
            //Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Explicit Wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            Thread.Sleep(30);
        }
        [TearDown]
        public void TearDown()
        {
            //Close the current window
            driver.Quit();
        }
    }
}
