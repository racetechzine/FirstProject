using FirstProj.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProj
{
    class Program
    {
        //  IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            


            

         }

    }
    //NUnit for Buttons Pg
    [TestFixture]
    class ButtonsPageTests : Base
    {
     
        //Add Multiple Buttons Page
        [Test]
        public void AddMultipeButton()
        {
            //Definition for report test
           SpecFlow.ButtonsSpecFlowFeatureSteps.test = SpecFlow.ButtonsSpecFlowFeatureSteps.extent.StartTest("Check whether user able to Add Multiple Button");

            //Creating object for Buttonspage and calling Add method
            Pages.Buttons BObject = new Pages.Buttons();
            BObject.AddMultipleButton(2);

        }
        //Add Buttons Page
        [Test]
        public void AddButton()
        {
            //Definition for report test
            SpecFlow.ButtonsSpecFlowFeatureSteps.test = SpecFlow.ButtonsSpecFlowFeatureSteps.extent.StartTest("Check whether user able to Add Button");

            //Creating object for Buttonspage and calling Add, Edit and Delete method
            Pages.Buttons BObject = new Pages.Buttons();
            BObject.AddButton();
           
        }
        //Edit Button
        [Test]
        public void EditButton()
        {
            //Definition for report test
            SpecFlow.ButtonsSpecFlowFeatureSteps.test = SpecFlow.ButtonsSpecFlowFeatureSteps.extent.StartTest("Check whether user able to Edit Newly Added Button");

            //Creating object for Buttonspage and calling Add, Edit method
            Pages.Buttons BObject = new Pages.Buttons();
            BObject.AddButton();
            BObject.EditButton();
        }
        //Delete Button
        [Test]
        public void DeleteButton()
        {
            //Definition for report test
            SpecFlow.ButtonsSpecFlowFeatureSteps.test = SpecFlow.ButtonsSpecFlowFeatureSteps.extent.StartTest("Check whether user able to Delete Newly Added Button");

            //Creating object for Buttonspage and calling Add, Delete method
            Pages.Buttons BObject = new Pages.Buttons();
            BObject.AddButton();
            BObject.DeleteButton();
        }
        //TearDown to close driver
        [TearDown]
        public void CloseDriver()
        {
            //End the test on report
            SpecFlow.ButtonsSpecFlowFeatureSteps.extent.EndTest(SpecFlow.ButtonsSpecFlowFeatureSteps.test);
            //Flush the report
            SpecFlow.ButtonsSpecFlowFeatureSteps.extent.Flush();
            //closing the web browser
            GlobalDef.driver.Close();

        }
    }
    }
