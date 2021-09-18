/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomateFacebookApp.SignupAction
{
    public class SignupActionclass : Base.Baseclass
    {
        public static void SignupPage()
        {
            try
            {
                
                IWebElement createacc = driver.FindElement(By.XPath("//*[@class='_6ltg'][2]"));
                createacc.Click();
                System.Threading.Thread.Sleep(2000);

                //Find firstname using name  and enter values
                driver.FindElement(By.Name("firstname")).SendKeys("Santhosh");
                logger.Error("Field not found");
                System.Threading.Thread.Sleep(1000);

                //Find lastname using name  and enter values
                driver.FindElement(By.Name("lastname")).SendKeys("M");
                logger.Error("Field not found");
                System.Threading.Thread.Sleep(1000);

                //Find Email using name  and enter values
                driver.FindElement(By.Name("reg_email__")).SendKeys("santhosh23@gmail.com");
                logger.Error("Field not found");
                System.Threading.Thread.Sleep(1000);

                //Find password using name  and enter values
                driver.FindElement(By.Name("reg_passwd__")).SendKeys("Sjfk4566");
                logger.Info("Field not found");
                System.Threading.Thread.Sleep(1000);

                //Find birthday date using name and enter values
                SelectElement bDay = new SelectElement(driver.FindElement(By.Name("birthday_day")));
                bDay.SelectByText("23");
                logger.Error("Field not found");
                System.Threading.Thread.Sleep(1000);

                //Find birthday month using Id and enter values
                SelectElement bMonth = new SelectElement(driver.FindElement(By.Id("month")));
                bMonth.SelectByValue("7");
                logger.Info("Field not found");
                System.Threading.Thread.Sleep(1000);

                //Find birthday year using Id and enter values
                SelectElement bYear = new SelectElement(driver.FindElement(By.Id("year")));
                bYear.SelectByValue("2000");
                logger.Info("Field not found");
                System.Threading.Thread.Sleep(1000);

                //Find gender using Xpath
                driver.FindElement(By.XPath("//*[@class='mtm _5wa2 _5dbb'][1]")).Click();
                System.Threading.Thread.Sleep(1000);

                //Find register button using name 
                driver.FindElement(By.Name("websubmit")).Click();
                System.Threading.Thread.Sleep(1000);
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
