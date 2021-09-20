/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
*/
using AutomateFacebookApp.DoAction;
using AutomateFacebookApp.ExtendReport;
using AventStack.ExtentReports;
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
        public static ILog logger = LogManager.GetLogger(typeof(FBApplication));

        public static IWebDriver driver;

        //Exptend report class
        ExtentReports reports = ReportClass.report();
        ExtentTest test;
        [SetUp]
        public void Setup()
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation FaceBook");
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
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            //Close the current window
            driver.Quit();
        }
    }
}
