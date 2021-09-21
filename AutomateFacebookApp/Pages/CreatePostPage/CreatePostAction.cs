/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutoItX3Lib;
using System;

namespace AutomateFacebookApp.Pages.CreatePostPage
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
                System.Threading.Thread.Sleep(4000);

                //upload a photo
                post.addPhoto.Click();
                System.Threading.Thread.Sleep(4000);

                //AutoIt- Handle Windows that do not belong to Browser
                AutoItX3 autoIt = new AutoItX3();
                //Activate so that next set of Action happen on this window
                autoIt.WinActivate("Open");
                //Upload an image
                autoIt.Send(@"C:\Users\sona.g\Desktop\download.jpg");
                System.Threading.Thread.Sleep(2000);
                autoIt.Send("{Enter}");
                System.Threading.Thread.Sleep(4000);
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
