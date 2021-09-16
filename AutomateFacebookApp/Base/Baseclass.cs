/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
*/
using AutomateFacebookApp.DoAction;
using log4net;
using log4net.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;


namespace AutomateFacebookApp.Base
{
    public class Baseclass
    {
       // private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public static ILog logger = LogManager.GetLogger(typeof(DoActions));

        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            //Launching chrome browser
            logger.Info("Launching browser");
            driver = new ChromeDriver();
            //Get the facebook URL
            driver.Url = "https://www.facebook.com/";
            
            logger.Info("Exit");
        }
        [TearDown]
        public void TearDown()
        {
            //Close the current window
            driver.Quit();
        }
    }
}
