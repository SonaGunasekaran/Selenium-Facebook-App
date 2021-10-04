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
        string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateFacebookApp\AutomateFacebookApp\CsvFile\FBfile.csv";
        string signupFilePath = @"C:\Users\sona.g\source\repos\AutomateFacebookApp\AutomateFacebookApp\CsvFile\SignupFile.csv";
        string emailCsvPath = @"C:\Users\sona.g\source\repos\AutomateFacebookApp\AutomateFacebookApp\CsvFile\Emailfile.csv";

        [Test, Order(1)]
        public void CheckInputFieldsForSignupPage()
        {
            DoAction.SignupActionclass.SignupPage(signupFilePath, "FirstName,LastName,Email,Password,Bday,BMonth,BYear");
        }

        [Test, Order(2)]
        public void CheckInputFields()
        {
            DoAction.DoActions.FacebookTitle();
            DoAction.DoActions.LoadUserData(csvFilePath, "Email,Password");
        }


        [Test, Order(3)]
        public void CheckInputFieldsForPostPage()
        {
            DoAction.CreatePostAction.CheckEmailAndPassword();
        }


        [Test, Order(34)]
        public void NegativeTestForLoginPage()
        {
            NegativeTestCases.NegativeLoginAction.CheckEmailAndPassword();
        }

        [Test]
        public void TestMethodForEmailSending()
        {
            Email.UserData(emailCsvPath, "From,To,Password");
        }
    }
}