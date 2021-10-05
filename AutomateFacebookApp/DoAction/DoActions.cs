/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutoItX3Lib;
using AutomateFacebookApp.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomateFacebookApp.DoAction
{
    public class DoActions : Base.Baseclass
    {
        public static void FacebookTitle()
        {
            string title = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            //Get Facebook title
            string ftitle = driver.Title;
            //Takescreenshot();
            //check whether the title equal or not
            Assert.Pass(title, ftitle);
        }

        public static void SignupPage(string csvFilePath1, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath1))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    try
                    {
                        SignupPage signup = new SignupPage(driver);
                        signup.createacc.Click();
                        System.Threading.Thread.Sleep(2000);

                        string expected = "பதிவு செய்க";
                        string actual = signup.signupDisplay.Text;
                        Assert.AreEqual(actual, expected);

                        //Enter the firstname
                        signup.firstName.SendKeys(fields[0]);
                        System.Threading.Thread.Sleep(1000);

                        //Enter the lastname
                        signup.lastName.SendKeys(fields[1]);
                        System.Threading.Thread.Sleep(1000);

                        //Enter the Email 
                        signup.email.SendKeys(fields[2]);
                        System.Threading.Thread.Sleep(1000);

                        //Enter the password 
                        signup.password.SendKeys(fields[3]);
                        System.Threading.Thread.Sleep(1000);

                        //Find birthday date using name and enter values
                        SelectElement day = new SelectElement(signup.bday);
                        day.SelectByText(fields[4]);
                        logger.Error("Field not found");
                        System.Threading.Thread.Sleep(1000);

                        //Find birthday month using Id and enter values
                        SelectElement month = new SelectElement(signup.bMonth);
                        month.SelectByValue(fields[5]);
                        logger.Error("Field not found");
                        System.Threading.Thread.Sleep(1000);

                        //Find birthday year using Id and enter values
                        SelectElement year = new SelectElement(signup.bYear);
                        year.SelectByValue(fields[6]);
                        logger.Error("Field not found");
                        System.Threading.Thread.Sleep(1000);

                        //Click on gender
                        signup.gender.Click();
                        System.Threading.Thread.Sleep(1000);
                        Takescreenshot();

                        //Click on register button
                        signup.submit.Click();
                        System.Threading.Thread.Sleep(1000);

                        Assert.AreNotEqual(driver.Url, "https://www.facebook.com/?sk=welcome");
                    }
                    catch (Exception ex)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
                    }
                }
            }
        }
        public static void LoginIntoFacebook(string csvFilePath2, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath2))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    try
                    {
                        FBLoginPage login = new FBLoginPage(driver);
                        //Check email by name
                        login.email.SendKeys(fields[0]);
                        System.Threading.Thread.Sleep(1000);

                        //check password by id
                        login.password.SendKeys(fields[1]);
                        System.Threading.Thread.Sleep(1000);

                        //check login by loginbutton
                        login.loginbtn.Click();
                        Takescreenshot();

                        string logintitle = "Facebook";
                        string logintitle1 = driver.Title;
                        Assert.AreEqual(logintitle, logintitle1);
                    }
                    catch(Exception ex)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
                    }
                }
            }
        }

        public static void CheckForPostPage()
        {
            try
            {
                string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateFacebookApp\AutomateFacebookApp\CsvFile\FBfile.csv";
                LoginIntoFacebook(csvFilePath, "Email,Password");
                FBCreatePostPage post = new FBCreatePostPage(driver);
                System.Threading.Thread.Sleep(4000);

                //Click the home icon 
                post.homeIcon.Click();
                System.Threading.Thread.Sleep(4000);

                //Click the create post 
                post.createPost.Click();
                System.Threading.Thread.Sleep(4000);

                //Validation
                Assert.AreEqual("Create Post", post.postText.Text);

                //Add some text in the text field
                post.text.SendKeys("Something");
                System.Threading.Thread.Sleep(4000);
                logger.Info("Field not found");

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

                ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,1500)");
                System.Threading.Thread.Sleep(1000);

                //Validating whether the Text post is equal or not
                string expected = "Something";
                string actual = post.aboutPost.Text;
                Assert.AreEqual(actual, expected);

                //Validating whether the image is displayed
                Assert.IsTrue(post.img.Displayed);

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
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
            }
        }
    }
}
