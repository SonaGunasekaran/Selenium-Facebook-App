/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateFacebookApp.Pages.CreatePostPage
{
    public class FBCreatePostPage
    {
        public FBCreatePostPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        [CacheLookup]
        public IWebElement homeIcon;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div/div[3]/div/div[2]/div/div/div/div[1]/div/div[1]/span")]
        [CacheLookup]
        public IWebElement createPost;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div/div/div[1]/div[1]/div/div[1]/h2/span/span")]
        [CacheLookup]
        public IWebElement postText;

        [FindsBy(How = How.XPath, Using = "//*[@class='_1mf _1mj']")]
        [CacheLookup]
        public IWebElement text;

        [FindsBy(How = How.XPath, Using = "//*[@class='dwxx2s2f dicw6rsg kady6ibp rs0gx3tq'] [1]")]
        [CacheLookup]
        public IWebElement uploadPhoto;

        [FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
        [CacheLookup]
        public IWebElement addPhoto;

        [FindsBy(How = How.XPath, Using = "//*[@class='k4urcfbm dati1w0a hv4rvrfc i1fnvgqd j83agx80 rq0escxv bp9cbjyn discj3wi']")]
        [CacheLookup]
        public IWebElement postbtn;

        [FindsBy(How = How.XPath, Using = "  //*[@class='kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x c1et5uql ii04i59q']")]
        [CacheLookup]
        public IWebElement aboutPost;

        [FindsBy(How = How.XPath, Using = "//*[@class='j83agx80 l9j0dhe7']")]
        [CacheLookup]
        public IWebElement arrowIcon;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[4]/div[2]/div/div/div[1]/div[1]/div/div/div/div/div/div/div/div/div[1]/div/div[3]/div/div[4]/div/div[1]/div[2]/div/div/div/div/span")]
        [CacheLookup]
        public IWebElement SignOut;

        [FindsBy(How = How.XPath, Using = "//*[@class='_8e63 _ihd _6s']")]
        [CacheLookup]
        public IWebElement loginDisplay;

    }

}
