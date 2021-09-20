/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.ExtendReport;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace AutomateFacebookApp
{
    public class FBApplication : Base.Baseclass
    {
        [Test, Order(1)]
        public void CheckInputFieldsForSignupPage()
        {
            SignupAction.SignupActionclass.SignupPage();
        }

        [Test, Order(2)]
        public void CheckInputFields()
        {
            DoAction.DoActions.FacebookTitle();
            DoAction.DoActions.CheckEmailAndPassword();
        }

        [Test, Order(3)]
        public void CheckInputFieldsForPostPage()
        { 
            PostAction.CreatePostAction.CheckEmailAndPassword();
        }
    }
}