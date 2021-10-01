/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using NUnit.Framework;
using System;

namespace AutomateFacebookApp.Pages.LoginPage
{
    public class DoActions : Base.Baseclass
    {
        public static void FacebookTitle()
        {
            string title = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            //Get Facebook title
            string ftitle = driver.Title;
            //Takescreenshot();
            //check whether the title equal or not
            Assert.Pass(title, ftitle);
        }
        public static void CheckEmailAndPassword()
        {
            try
            {

                FBLoginPage login = new FBLoginPage(driver);
                //Enter the email
                login.email.SendKeys("santydx5@gmail.com");
                logger.Error("Field not found");

                //enter the password
                login.password.SendKeys("Santhosh23");
                logger.Error("Field not found");

                //click on loginbutton
                login.loginbtn.Click();
                Takescreenshot();
                System.Threading.Thread.Sleep(4000);

                string loginTitle = "Facebook";
                //Get Facebook title
                string title1 = driver.Title;
                Takescreenshot();
                //check whether the title equal or not
                Assert.Pass(title1, loginTitle);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
