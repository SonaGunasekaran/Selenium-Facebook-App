﻿/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.LoginPage;
using NUnit.Framework;

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

            //Enter the email
            login.email.SendKeys("santydx5@gmail.com");

            //enter the password
            login.password.SendKeys("Santhosh23");

            //click on loginbutton
            login.loginbtn.Click();
            System.Threading.Thread.Sleep(4000);
        }
    }
}
