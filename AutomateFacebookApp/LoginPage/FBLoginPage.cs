/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomateFacebookApp.LoginPage
{
    //Inherit from base class
    public class FBLoginPage : Base.Baseclass
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
            email.SendKeys("sona16061999@gmail.com");
            //check password by id
            IWebElement passwrd = driver.FindElement(By.Id("pass"));
            passwrd.SendKeys("12345678");
        }
    }
}
