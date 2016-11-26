using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;

namespace FirstProj.SpecFlow
{
    [Binding]
    public class ButtonsSpecFlowFeatureSteps
    {
        //Intialise obj forreport
        public static ExtentReports extent;

        //Initialise test for the report
        public static ExtentTest test;

        [Given(@"Login to the MDT Portal")]
        public void GivenLoginToTheMDTPortal()
        {
           
            //Report definition
            extent = new ExtentReports(@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\ConsoleApplication1\TestReport\Test.html", true, DisplayOrder.NewestFirst);


            //Intialization definition
            GlobalDef.driver = new ChromeDriver();
            GlobalDef.driver.Manage().Window.Maximize();
            //Implicit Wait for Driver
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            //Creating object for loginpage and calling the loginsuccess method
            Pages.Login LObject = new Pages.Login();
            LObject.LoginSuccess();
        }
        
        [Given(@"Create a button")]
        public void GivenCreateAButton()
        {
      
            //Definition for report test
            test = extent.StartTest("Check whether user able to Add Button");

            //Creating object for Buttonspage and calling Add, Edit and Delete method
            Pages.Buttons BObject = new Pages.Buttons();
            BObject.AddButton();

        }
        [Given(@"Edit a button")]
        public void GivenEditAButton()
        {
            //Definition for report test
            test = extent.StartTest("Check whether user able to Edit Newly Added Button");

            //Creating object for Buttonspage and calling Add, Edit method
            Pages.Buttons BObject = new Pages.Buttons();
           BObject.AddButton();
            BObject.EditButton();
        }
        [Given(@"Delete a button")]
        public void GivenDeleteAButton()
        {

            //Definition for report test
            test = extent.StartTest("Check whether user able to Delete Newly Added Button");

            //Creating object for Buttonspage and calling Add, Delete method
            Pages.Buttons BObject = new Pages.Buttons();
            BObject.AddButton();
            BObject.DeleteButton();
        }


        [Then(@"Close the driver")]
        public void ThenCloseTheDriver()
        {
            //End the test on report
            extent.EndTest(test);
            //Flush the report
            extent.Flush();
            //closing the web browser
            GlobalDef.driver.Close();
        }


    }
}
