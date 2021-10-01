/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutoItX3Lib;
using AutomateFacebookApp.Pages.LoginPage;
using NUnit.Framework;
using System;

namespace AutomateFacebookApp.Pages.CreatePostPage
{
    public class CreatePostAction : Base.Baseclass
    {
        public static void CheckEmailAndPassword()
        {
            try
            {
                DoActions.CheckEmailAndPassword();
                FBCreatePostPage post = new FBCreatePostPage(driver);

                //Click the home icon 
                post.homeIcon.Click();
                System.Threading.Thread.Sleep(4000);

                //Click the create post 
                post.createPost.Click();
                System.Threading.Thread.Sleep(4000);

                Assert.AreEqual("Create Post", post.postText.Text);
                
                //Add some text in the text field
                post.text.SendKeys("Something");
                System.Threading.Thread.Sleep(4000);
                logger.Info("Field not found");
                Takescreenshot();

                //click photo icon
                post.uploadPhoto.Click();
                System.Threading.Thread.Sleep(4000);

                //upload a photo
                post.addPhoto.Click();
                Takescreenshot();
                System.Threading.Thread.Sleep(4000);

                //AutoIt- Handle Windows that do not belong to Browser
                AutoItX3 autoIt = new AutoItX3();

                //Activate so that next set of Action happen on this window
                autoIt.WinActivate("Open");

                //Upload an image
                autoIt.Send(@"C:\Users\sona.g\Desktop\download.jpg");
                System.Threading.Thread.Sleep(2000);
                autoIt.Send("{Enter}");

                Takescreenshot();
                System.Threading.Thread.Sleep(4000);

                //Click on post button
                post.postbtn.Click();

                System.Threading.Thread.Sleep(8000);

                string expected = "Something";
                string actual = post.aboutPost.Text;
                Assert.AreEqual(actual, expected);

                //Click on dropdown
                post.arrowIcon.Click();
                System.Threading.Thread.Sleep(4000);

                //click on signOut
                post.SignOut.Click();
                System.Threading.Thread.Sleep(4000);

                Assert.IsTrue(post.loginDisplay.Displayed);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
