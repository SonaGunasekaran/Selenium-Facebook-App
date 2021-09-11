using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomateFacebookApp.DoAction
{
    public class DoActions : Base.Baseclass
    {
        public static void FacebookTitle()
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            //Get Facebook title
            string ftitle = driver.Title;
            //check whether the title equal or not
            Assert.Pass(title1, ftitle);
        }

        public static void CheckEmailAndPassword()
        {
            //Check email by name 
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("santydx5@gmail.com");
            //check password by id
            IWebElement passwrd = driver.FindElement(By.Id("pass"));
            passwrd.SendKeys("Santhosh23");
            IWebElement login = driver.FindElement(By.Name("login"));
            login.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
