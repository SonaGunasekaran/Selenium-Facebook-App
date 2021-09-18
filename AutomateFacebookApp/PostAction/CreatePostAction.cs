/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.CreatePost;
using System;

namespace AutomateFacebookApp.PostAction
{
    public class CreatePostAction : Base.Baseclass
    {
        public static void CheckEmailAndPassword()
        {
            try
            {
                FBCreatePostPage post = new FBCreatePostPage(driver);

                //enter the email
                post.email.SendKeys("santydx5@gmail.com");
                logger.Info("Field not found");

                //enter the password
                post.password.SendKeys("Santhosh23");
                logger.Info("Field not found");

                //click on loginbutton
                post.loginbtn.Click();
                System.Threading.Thread.Sleep(8000);

                //Click the home icon 
                post.homeIcon.Click();
                System.Threading.Thread.Sleep(4000);

                //Click the create post 
                post.createPost.Click();
                System.Threading.Thread.Sleep(4000);
                
                //Add some text in the text field
                post.text.SendKeys("Something");
                System.Threading.Thread.Sleep(4000);
                logger.Info("Field not found");

                //click photo icon
                post.uploadPhoto.Click();
                System.Threading.Thread.Sleep(8000);

                //upload a photo
                post.addPhoto.Click();
                System.Threading.Thread.Sleep(8000);
                post.addPhoto.SendKeys(@"C:\Users\sona.g\Pictures\Screenshots\Screenshot(1).png");
                System.Threading.Thread.Sleep(8000);
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
