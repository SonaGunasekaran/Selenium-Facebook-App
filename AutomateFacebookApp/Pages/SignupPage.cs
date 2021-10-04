/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :21/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateFacebookApp.Pages
{
    public class SignupPage
    {
        public SignupPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='_6ltg'][2]")]
        [CacheLookup]
        public IWebElement createacc;

        [FindsBy(How = How.XPath, Using = "//*[@class='mbs _52lq fsl fwb fcb']")]
        [CacheLookup]
        public IWebElement signupDisplay;

        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement firstName;

        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement lastName;

        [FindsBy(How = How.Name, Using = "reg_email__")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@class='mtm _5wa2 _5dbb'][1]")]
        [CacheLookup]
        public IWebElement gender;

        [FindsBy(How = How.Name, Using = "websubmit")]
        [CacheLookup]
        public IWebElement submit;
    }
}
