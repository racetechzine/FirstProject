using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace FirstProj.Pages
{
    class Login
    {
        //Constructor
        public Login()
        {
            PageFactory.InitElements(GlobalDef.driver, this);
        }

        //PageFactory Def
        //UserName Definitions
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement Username { get; set; }
        //Password
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password { get; set; }
        //LoginButton
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/form/div/div/div/div[2]/div[3]/input")]
        private IWebElement LoginButton { get; set; }
        //Welcome Header Verification 
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div/h2")]
        private IWebElement Welcome { get; set; }


        //Method
        public void LoginSuccess()
        {
            //populate fromExcel
            ExcelLib.PopulateInCollection(@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\TestData1.xlsx", "LoginPage");
            //Launch URL

            GlobalDef.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "url"));


            //Create Webelement for Username
            //IWebElement uname = driver.FindElement(By.Id("UserName"));
            //uname.SendKeys("jiya");
            //POM
            //GlobalDef.Textbox(GlobalDef.driver, "Id", "UserName", "jiya");
            //PageFactory 
            Username.SendKeys(ExcelLib.ReadData(2,"username"));
            //Using Excel for Data Import

            // GlobalDef.driver.FindElement(By.Id("UserName")).SendKeys((ExcelLib.ReadData(2,"username")));

            //Create Webelement for Password
            //IWebElement pwd = driver.FindElement(By.Id("Password"));
            //pwd.SendKeys("Jiya@345");
            //POM
            //GlobalDef.Textbox(GlobalDef.driver, "Id", "Password", "Jiya@345");
            //PageFactory 
            Password.SendKeys(ExcelLib.ReadData(2,"password"));
            //Using Excel for Data Import

            //  GlobalDef.driver.FindElement(By.Id("Password")).SendKeys((ExcelLib.ReadData(2, "password")));


            //Create Webelement for Login button
            //IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[3]/form/div/div/div/div[2]/div[3]/input"));
            //LoginButton.Click();
            //POM
            //GlobalDef.ActionButton(GlobalDef.driver, "XPath", "/html/body/div[3]/form/div/div/div/div[2]/div[3]/input");
            //PageFactory
            LoginButton.Click();

            //Login Verification
          IWebElement Welcome = GlobalDef.driver.FindElement(By.XPath("//*[@id='container']/div/div/h2"));

            string Welcometxt = Welcome.Text;
            if (Welcome.Text == "Welcome")
            {
                Console.WriteLine("Login Successfully, Test Passed");

            }
            else
                Console.WriteLine("Login Failed, Test Fail");
            //Login Screenshot
            GlobalDef.SaveScreenshot(GlobalDef.driver, "LoginSuccessfulPage");
        }
        }
}
