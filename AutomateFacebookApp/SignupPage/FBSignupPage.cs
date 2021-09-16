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
using SeleniumExtras.PageObjects;
using System.Threading;

namespace AutomateFacebookApp.SignupPage
{
    public class FBSignupPage
    {
        public FBSignupPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='_6ltg'][2]")]
        [CacheLookup]
        public IWebElement createacc;

        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement firstname;

        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement lastname;

        [FindsBy(How = How.Name, Using = "reg_email__")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "birthday_day")]
        [CacheLookup]
        public SelectElement bDay;

        [FindsBy(How = How.Id, Using = "month")]
        [CacheLookup]
        public SelectElement bMonth;

        [FindsBy(How = How.Id, Using = "year")]
        [CacheLookup]
        public SelectElement bYear;

        [FindsBy(How = How.XPath, Using = "//*[@class='mtm _5wa2 _5dbb'][1]")]
        [CacheLookup]
        public IWebElement gender;

        [FindsBy(How = How.Name, Using = "websubmit")]
        [CacheLookup]
        public IWebElement loginbtn;

    }
}

