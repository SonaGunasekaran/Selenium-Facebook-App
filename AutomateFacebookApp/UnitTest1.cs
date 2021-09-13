/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */

using NUnit.Framework;


namespace AutomateFacebookApp
{
    public class FBApplication : Base.Baseclass
    {
        [Test]
        public void CheckInputFieldsForSignupPage()
        {
            SignupPage.FBSignupPage.FbSignupPage();
        }
        [Test]
        public void CheckInputFields()
        {
            //DoAction.DoActions.FacebookTitle();
            DoAction.DoActions.CheckEmailAndPassword();
        }
        [Test]
        public void CheckInputFieldsForPostPage()
        {
            CreatePost.FBCreatePostPage.FbCreatePost();
        }

    }
}