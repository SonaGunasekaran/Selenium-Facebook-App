/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
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
        public static void LoadUserData(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
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

                        string expected = "Rambo";
                        //Get Facebook title
                        string actual = login.UserName.Text;
                        //check whether the title equal or not
                        Assert.AreEqual(actual,expected);
                    }
                    catch(Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }
            }
        }
    }
}
