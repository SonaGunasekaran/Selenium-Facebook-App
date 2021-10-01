/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.ExtendReport;
using NUnit.Framework;

namespace AutomateFacebookApp
{
    public class FBApplication : Base.Baseclass
    {
        [Test, Order(1)]
        public void CheckInputFieldsForSignupPage()
        {
            Pages.SignupPage.SignupActionclass.SignupPage();
        }

        [Test, Order(2)]
        public void CheckInputFields()
        {
            Pages.LoginPage.DoActions.FacebookTitle();
            Pages.LoginPage.DoActions.CheckEmailAndPassword();
        }


        [Test, Order(3)]
        public void CheckInputFieldsForPostPage()
        {
            Pages.CreatePostPage.CreatePostAction.CheckEmailAndPassword();
        }

        [Test]
        public void TestMethodForEmailSending()
        {
            Email.UserData();
        }
    }
}