/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :18/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using System.Net;
using System.Net.Mail;
namespace AutomateFacebookApp.ExtendReport
{
    public class Email : Base.Baseclass
    {
        public static void UserData()
        {
            using (MailMessage mail = new MailMessage())
            {
                //Add sender mail id
                mail.From = new MailAddress("sona16test@gmail.com");
                //To recepiant mail id
                mail.To.Add("sona16test@gmail.com");
                mail.Subject = "Facebook Automation Report";
                mail.Body = "Kindly find the attachment below";
                mail.IsBodyHtml = true;
                //Add the report attachment
                mail.Attachments.Add(new Attachment(@"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\ExtendReport\index.html"));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    //sending credentials to network
                    smtp.Credentials = new NetworkCredential("sona16test@gmail.com", "sweetone12#");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    var sendingMail = "Message sent.";
                    Assert.IsTrue(driver.FindElement(By.XPath("//*[@class='bAq']")).Text.Contains(sendingMail));

                }
            }
        }
    }
}



