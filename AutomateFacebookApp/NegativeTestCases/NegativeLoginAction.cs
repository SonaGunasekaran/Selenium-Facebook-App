/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :21/09/2021
 */
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using System;

namespace AutomateFacebookApp.NegativeTestCases
{
    public class NegativeLoginAction : Base.Baseclass
    {
        public static void CheckEmailAndPassword(string csvFilePath ,string dataheader)
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
                        NegativeLogin login = new NegativeLogin(driver);
                        //Check email by name
                        login.nemail.SendKeys(fields[0]);
                        System.Threading.Thread.Sleep(1000);

                        //check password by id
                        login.npassword.SendKeys(fields[1]);
                        System.Threading.Thread.Sleep(1000);

                        //check login by loginbutton
                        login.nloginbtn.Click();
                        Takescreenshot();

                        Assert.IsTrue(login.invalid.Displayed);
                    }
                    catch (Exception ex)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_ELEMENT, "Unable to locate element");
                    }
                }
            }
        }
    }
}

