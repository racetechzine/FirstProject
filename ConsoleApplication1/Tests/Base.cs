
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProj.Tests
{
    class Base
    {
        ////Intialise obj forreport
        //public static ExtentReports extent;

        ////Initialise test for the report
        //public static ExtentTest test;

        //Setup method for button
        [SetUp]
        public void LoginStep()
        {
            //Report definition
           SpecFlow.ButtonsSpecFlowFeatureSteps.extent = new ExtentReports(@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\ConsoleApplication1\TestReport\Test.html", true, DisplayOrder.NewestFirst);


            //Intialization definition
            GlobalDef.driver = new ChromeDriver();
            GlobalDef.driver.Manage().Window.Maximize();
            //Implicit Wait for Driver
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            //Creating object for loginpage and calling the loginsuccess method
            Pages.Login LObject = new Pages.Login();
            LObject.LoginSuccess();
        }
    }
}
