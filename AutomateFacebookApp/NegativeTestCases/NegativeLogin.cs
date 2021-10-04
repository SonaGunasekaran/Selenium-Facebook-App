/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :21/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateFacebookApp.NegativeTestCases
{
    public class NegativeLogin
    {
        public NegativeLogin(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement nemail;
        
        [FindsBy(How = How.Name, Using = "pass")]
        [CacheLookup]
        public IWebElement npassword;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement nloginbtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='email_container']/div[2]")]
        [CacheLookup]
        public IWebElement invalid;
    }
}
