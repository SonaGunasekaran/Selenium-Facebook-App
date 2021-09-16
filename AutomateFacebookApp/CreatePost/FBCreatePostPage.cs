/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateFacebookApp.CreatePost
{
    public class FBCreatePostPage
    {
        public FBCreatePostPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        [CacheLookup]
        public IWebElement homeIcon;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[3]/div/div[2]/div/div/div/div[1]/div")]
        [CacheLookup]
        public IWebElement createPost;

        [FindsBy(How = How.XPath, Using = "//*[@class='_1mf _1mj']")]
        [CacheLookup]
        public IWebElement text;

    }

}
