/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using OpenQA.Selenium;

namespace AutomateFacebookApp.SignupPage
{
    public class FBSignupPage :Base.Baseclass
    {
        public static void FbSignupPage()
        {
            //check first name by name 
            IWebElement fName = driver.FindElement(By.Name("firstname"));
            fName.SendKeys("Sona");
            //check last name by name 
            IWebElement lName = driver.FindElement(By.Name("lastname"));
            lName.SendKeys("Guna");
            //check email name by name 
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("sona16061999@gmail.com");
            //check password name by name 
            IWebElement passwrd = driver.FindElement(By.Name("pass"));
            passwrd.SendKeys("Sona123#$%");
        }
    }
}
