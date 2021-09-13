/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using java.awt;
using java.awt.@event;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomateFacebookApp.SignupPage
{
    public class FBSignupPage : Base.Baseclass
    {
        public static void FbSignupPage()
        {
            //Find Create Account button using Xpath
            IWebElement createAcc = driver.FindElement(By.XPath("//*[@class='_6ltg'][2]"));
            createAcc.Click();
            System.Threading.Thread.Sleep(1000);

            //Find firstname using name  and enter values
            driver.FindElement(By.Name("firstname")).SendKeys("Santy");
            System.Threading.Thread.Sleep(1000);

            //Find lastname using name  and enter values
            driver.FindElement(By.Name("lastname")).SendKeys("M");
            System.Threading.Thread.Sleep(1000);

            //Find Email using name  and enter values
            driver.FindElement(By.Name("reg_email__")).SendKeys("sandx5@gmail.com");
            System.Threading.Thread.Sleep(1000);

            //Find password using name  and enter values
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("santhosh23");
            System.Threading.Thread.Sleep(1000);

            //Find birthday date using name and enter values
            SelectElement bDay = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            bDay.SelectByValue("23");
            System.Threading.Thread.Sleep(1000);

            //Find birthday month using Id and enter values
            SelectElement bMonth = new SelectElement(driver.FindElement(By.Id("month")));
            bMonth.SelectByValue("7");
            System.Threading.Thread.Sleep(1000);

            //Find birthday year using Id and enter values
            SelectElement bYear = new SelectElement(driver.FindElement(By.Id("year")));
            bYear.SelectByValue("2000");
            System.Threading.Thread.Sleep(1000);

            //Find gender using Xpath 
            driver.FindElement(By.XPath("//*[@class='mtm _5wa2 _5dbb'][1]")).Click();
            System.Threading.Thread.Sleep(1000);

            //Find register button using name 
            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(1000);



        }
    }
}
