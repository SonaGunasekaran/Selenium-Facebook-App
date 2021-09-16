/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomateFacebookApp
{
    public class FBApplication : Base.Baseclass
    {
        [Test]
        public void CheckInputFieldsForSignupPage()
        {
            SignupAction.SignupActionclass.SignupPage();
        }
        [Test]
        public void CheckInputFields()
        {
            DoAction.DoActions.FacebookTitle();
            DoAction.DoActions.CheckEmailAndPassword();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
        }
        [Test]
        public void CheckInputFieldsForPostPage()
        {
            PostAction.CreatePostAction.CheckEmailAndPassword();
        }

    }
}