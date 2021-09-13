using OpenQA.Selenium;

namespace AutomateFacebookApp.CreatePost
{
    public class FBCreatePostPage :Base.Baseclass
    {
        public static void FbCreatePost()
        {
            //Find Email using name and enter values
            driver.FindElement(By.Name("email")).SendKeys("santydx5@gmail.com");

            //Find password using name and enter values
            driver.FindElement(By.Name("pass")).SendKeys("Santhosh23");

            //Find login button using name 
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(4000);

            //Click the home icon using Xpath
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")).Click(); 
            System.Threading.Thread.Sleep(4000);

            //Click the create post using Xpath
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[3]/div/div[2]/div/div/div/div[1]/div")).Click();
            System.Threading.Thread.Sleep(4000);

            driver.FindElement(By.XPath("//*[@class='_1mf _1mj']")).SendKeys("Something");
            System.Threading.Thread.Sleep(4000);

        }

    }
}
