/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.SignupPage;

namespace AutomateFacebookApp.SignupAction
{
    public class SignupActionclass : Base.Baseclass
    {
        public static void SignupPage()
        {
            FBSignupPage signup = new FBSignupPage(driver);

            signup.createacc.Click();
            System.Threading.Thread.Sleep(1000);

            //Find firstname using name  and enter values
            signup.firstname.SendKeys("Santy");
            System.Threading.Thread.Sleep(1000);

            //Find lastname using name  and enter values
            signup.lastname.SendKeys("M");
            System.Threading.Thread.Sleep(1000);

            //Find Email using name  and enter values
            signup.email.SendKeys("sandx5@gmail.com");
            System.Threading.Thread.Sleep(1000);

            //Find password using name  and enter values
            signup.password.SendKeys("santhosh23");
            System.Threading.Thread.Sleep(1000);

            //Find birthday date using name and enter values
            signup.bDay.SelectByValue("23");
            System.Threading.Thread.Sleep(1000);

            //Find birthday month using Id and enter values

            signup.bMonth.SelectByValue("7");
            System.Threading.Thread.Sleep(1000);

            //Find birthday year using Id and enter values

            signup.bYear.SelectByValue("2000");
            System.Threading.Thread.Sleep(1000);

            //Find gender using Xpath 
            signup.gender.Click();
            System.Threading.Thread.Sleep(1000);

            //Find register button using name 
            signup.loginbtn.Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
