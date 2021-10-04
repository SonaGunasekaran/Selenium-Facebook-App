/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :21/09/2021
 */
using NUnit.Framework;
using System;

namespace AutomateFacebookApp.NegativeTestCases
{
    public class NegativeLoginAction:Base.Baseclass
    {
        public static void CheckEmailAndPassword()
        {
            try
            {
                NegativeLogin login = new NegativeLogin(driver);
                //Enter the email
                login.nemail.SendKeys("sonagunaukj@hg.com");
                logger.Error("Field not found");

                //enter the password
                login.npassword.SendKeys("hsfgjj567");
                logger.Error("Field not found");

                //click on loginbutton
                login.nloginbtn.Click();
                Takescreenshot();
                System.Threading.Thread.Sleep(4000);

                Assert.IsTrue(login.invalid.Displayed);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}

