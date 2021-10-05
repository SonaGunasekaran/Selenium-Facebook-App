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
        string negativeLoginPath = @"C:\Users\sona.g\source\repos\AutomateFacebookApp\AutomateFacebookApp\CsvFile\NegativeLogin.csv";
        [Test, Order(1)]
        public void CheckInputFieldsForSignupPage()
        {
            DoAction.DoActions.SignupPage(signupFilePath, "FirstName,LastName,Email,Password,Bday,BMonth,BYear");
        }

        [Test, Order(2)]
        public void CheckInputFields()
        {
            DoAction.DoActions.FacebookTitle();
            DoAction.DoActions.LoginIntoFacebook(csvFilePath, "Email,Password");
        }


        [Test, Order(3)]
        public void CheckInputFieldsForPostPage()
        {
            DoAction.DoActions.CheckForPostPage();
        }



        [Test, Order(4)]
        public void NegativeTestForLoginPage()
        {
            NegativeTestCases.NegativeLoginAction.CheckEmailAndPassword(negativeLoginPath, "Email,Password");
        }

        [Test]
        public void TestMethodForEmailSending()
        {
            Email.UserData(emailCsvPath, "From,To,Password");
        }
    }
}