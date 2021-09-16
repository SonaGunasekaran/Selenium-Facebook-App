/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.CreatePost;

namespace AutomateFacebookApp.PostAction
{
    public class CreatePostAction : Base.Baseclass
    {
        public static void CheckEmailAndPassword()
        {
            FBCreatePostPage post = new FBCreatePostPage(driver);

            //enter the email
            post.email.SendKeys("santydx5@gmail.com");

            //enter the password
            post.password.SendKeys("Santhosh23");

            //click on loginbutton
            post.loginbtn.Click();
            System.Threading.Thread.Sleep(4000);

            //Click the home icon 
            post.homeIcon.Click();
            System.Threading.Thread.Sleep(4000);

            //Click the create post 
            post.createPost.Click();
            System.Threading.Thread.Sleep(4000);


            post.text.SendKeys("Something");
            System.Threading.Thread.Sleep(4000);
        }
    }
}
