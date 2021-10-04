/*
 * Project:Selenium WebDriver
 * Author:Sona G
 * Date :08/09/2021
 */
using AutomateFacebookApp.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomateFacebookApp.DoAction
{
    public class SignupActionclass : Base.Baseclass
    {
        public static void SignupPage(string csvFilePath, string dataHeader)
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
                        logger.Error("Field not found");
                        System.Threading.Thread.Sleep(1000);

                        //Find birthday date using name and enter values
                        SelectElement bDay = new SelectElement(driver.FindElement(By.Name("birthday_day")));
                        bDay.SelectByText(fields[4]);
                        logger.Error("Field not found");
                        System.Threading.Thread.Sleep(1000);

                        //Find birthday month using Id and enter values
                        SelectElement bMonth = new SelectElement(driver.FindElement(By.Id("month")));
                        bMonth.SelectByValue(fields[5]);
                        logger.Error("Field not found");
                        System.Threading.Thread.Sleep(1000);

                        //Find birthday year using Id and enter values
                        SelectElement bYear = new SelectElement(driver.FindElement(By.Id("year")));
                        bYear.SelectByValue(fields[6]);
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
                        logger.Error(ex.Message);
                    }
                }
            }
        }
    }
}
