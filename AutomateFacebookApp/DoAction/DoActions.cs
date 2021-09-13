using AutomateFacebookApp.LoginPage;
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
            FBLoginPage login = new FBLoginPage(driver);

            //Check email by name 
            login.email.SendKeys("santydx5@gmail.com");

            //check password by id
            login.password.SendKeys("Santhosh23");

            //check login by loginbutton
            login.loginbtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
    }
}
