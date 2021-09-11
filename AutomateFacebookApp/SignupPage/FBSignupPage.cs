/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using java.awt;
using java.awt.@event;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace AutomateFacebookApp.SignupPage
{
    public class FBSignupPage : Base.Baseclass
    {
        public static void FbSignupPage()
        {
            //check firstname by name
            IWebElement fName = driver.FindElement(By.Name("firstname"));
            fName.SendKeys("Sona");
            //check lastname by name 
            IWebElement lName = driver.FindElement(By.Name("lastname"));
            lName.SendKeys("Guna");
            //check email name by name
            IWebElement email = driver.FindElement(By.Name("reg_email__"));
            email.SendKeys("sona16061999@gmail.com");
            //check password name by name 
            IWebElement passwrd = driver.FindElement(By.Name(""));
            passwrd.SendKeys("Sona123#$%");

        }
    }
}
