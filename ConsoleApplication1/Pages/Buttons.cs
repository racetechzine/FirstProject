using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstProj.Pages
{
    class Buttons
    {
        public Buttons()
        {
            PageFactory.InitElements(GlobalDef.driver, this);
        }

        //Initialization of Buttons Element
        public string Buttonsname = "RtestName5";
        public string BDispValue = "RtestDisplay5";
        public string BPreCValue = "RPrecondition5";
        public string BValue = "RValue5";

        //Page Factory Def
        //Uinterface Navigation Definition
        [FindsBy(How = How.XPath, Using = "/ html / body / div[1] / div / div[2] / ul / li[5] / a")]
        private IWebElement Uinterface { get; set; }
        //Uinterface Buttons Definition
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul/li[5]/ul/li[3]/a")]
        private IWebElement UButtons { get; set; }
        //Uinterface ButtonsHeader Definition for Buttons Pg Verification
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/h2")]
        private IWebElement buttonHdr { get; set; }
        //Uinterface AddNew Button Definition
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/a")]
        private IWebElement addNew { get; set; }
        //Uinterface Create Header Verification
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[1]/span")]
        private IWebElement createNew { get; set; }
        // ButtonName Field Definition
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/div/div[2]/input")]
        private IWebElement bName { get; set; }
        // ButtonDisplayTitle Field Definition
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/div/div[4]/input")]
        private IWebElement bDisplayTitle { get; set; }
        //Create Webelement for ButtonLogo    
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/div/div[6]/span/span/span[2]/span")]
        private IWebElement bLogo { get; set; }
        //Create Webelement for ButtonLogo List   
        [FindsBy(How = How.XPath, Using = ("/html/body/div[7]/div/ul/li"))]
        private IList<IWebElement> cbl { get; set; }
        //Create Webelement for PreCondition
        [FindsBy(How = How.XPath, Using = ("/html/body/div[6]/div[2]/div/div[8]/input"))]
        private IWebElement bPreCondition { get; set; }
        //Create Webelement for NextScreen 
        [FindsBy(How = How.XPath, Using = ("/html/body/div[6]/div[2]/div/div[10]/span/span/span[2]/span"))]
        private IWebElement bNextScreen { get; set; }
        //Create Webelement for NextScreen List
        [FindsBy(How = How.XPath, Using = (".//*[@id='NEXT_SCREEN_DBID_listbox']/li[6]"))]
        private IWebElement bNextScreenList { get; set; }
        //Create Webelement for ValueUpdate
        [FindsBy(How = How.XPath, Using = ("/html/body/div[6]/div[2]/div/div[12]/input"))]
        private IWebElement bValueUpdate { get; set; }
        //Create Webelement for NextState
        [FindsBy(How = How.XPath, Using = ("/html/body/div[6]/div[2]/div/div[14]/span/span/span[1]"))]
        private IWebElement bNextState { get; set; }
        //Create Webelement for NextState List
        [FindsBy(How = How.XPath, Using = ("//*[@id='NEXT_STATE_DBID_listbox']/li[3]"))]
        private IWebElement bNextStateList { get; set; }
        //Create Webelement for PendingState
        [FindsBy(How = How.XPath, Using = ("/html/body/div[6]/div[2]/div/div[16]/span/span/span[2]/span"))]
        private IWebElement bPendingState { get; set; }
        //Create Webelement for PendingState List
        [FindsBy(How = How.XPath, Using = ("//*[@id='PENDING_STATE_DBID_listbox']/li[3]"))]
        private IWebElement bPendingStateList { get; set; }
        //Create Webelement for Entity Type
        [FindsBy(How = How.XPath, Using = ("html/body/div[6]/div[2]/div/div[18]/span/span/span[2]"))]
        private IWebElement bEntityType { get; set; }
        //Create Webelement for Entity Type List
        [FindsBy(How = How.XPath, Using = ("//*[@id='ETT_DBID_listbox']/li[3]"))]
        private IWebElement bEntityTypeList { get; set; }
        //Create Webelement for Override theme
        [FindsBy(How = How.XPath, Using = ("/html/body/div[6]/div[2]/div/div[20]/span[1]/span/span[1]"))]
        private IWebElement bOverride { get; set; }
        //Create Webelement for Override theme List
        [FindsBy(How = How.XPath, Using = ("/html/body/div[12]/div/ul/li[1]"))]
        private IWebElement bOverrideList { get; set; }
        //Create Webelement for Create button
        [FindsBy(How = How.XPath, Using = ("/html/body/div[6]/div[2]/div/div[27]/a[1]"))]
        private IWebElement CreateButton { get; set; }
        
        //Edit Button in Grid Definition
        [FindsBy(How = How.XPath, Using = ".//*[@id='grid']/div[4]/table/tbody/tr[1]/td[14]/a[1]")]
        private IWebElement editbGrid { get; set; }
        //Delete Button in Grid Definition
        [FindsBy(How = How.XPath, Using = ".//*[@id='grid']/div[4]/table/tbody/tr[1]/td[14]/a[2]")]
        private IWebElement deletebGrid { get; set; }
        // ButtonName field in Grid Definition
        [FindsBy(How = How.XPath, Using = ".//*[@id='grid']/div[4]/table/tbody/tr/td[1]")]
        private IWebElement buttonNameGrid { get; set; }






        //POM Def
        //public IWebElement editbGrid;
        //public IWebElement deletebGrid;
        //public IWebElement buttonNameGrid;
        // public IWebElement buttonHdr;

        public void AddMultipleButton(int count)
        {
            //populating the test data to collections
            ExcelLib.PopulateInCollection(@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\TestData1.xlsx", "ButtonsPage");


            //Create Webelement for UserInterface
            //IWebElement Uinterface = GlobalDef.driver.FindElement(By.XPath("/ html / body / div[1] / div / div[2] / ul / li[5] / a"));
            //Uinterface.Click();
            //Adding Multiple Records
            for (int row = 2; row <= count+1; row++)
            {
                //Page Factory Definition
                Uinterface.Click();


            //Create Webelement for Buttons
            //IWebElement UButtons = GlobalDef.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[5]/ul/li[3]/a"));
            //UButtons.Click();
            //PF
            UButtons.Click();
            Thread.Sleep(1000);
            // Buttons Page Verification
            //buttonHdr = GlobalDef.driver.FindElement(By.XPath("/html/body/div[2]/h2"));
        
            

                if (buttonHdr.Text == "Buttons")
                {
                    //Console.WriteLine("Login Successfully, Test Passed");
                    //Console.WriteLine("Navigate to Buttons Page Successful");

                    Thread.Sleep(500);
                    //Create Webelement for AddNewRecord
                    //IWebElement addNew = GlobalDef.driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                    //addNew.Click();
                    //PF AddNew button Click
                    addNew.Click();

                    //Create Webelement for Create Option
                    Thread.Sleep(1000);
                    //IWebElement ButtonNameLabel = GlobalDef.driver.FindElement(By.XPath("/html/body/div[7]/div[2]"));
                    //IWebElement ButtonNameLabel1 = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]"));

                    //Create Page Open verification                
                    if (bName.Displayed|| createNew.Text =="Create")
                    {

                        //Create Webelement for ButtonName
                        //IWebElement bName = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[2]/input"));
                        //bName.SendKeys(Buttonsname);
                        bName.SendKeys(ExcelLib.ReadData(row, "Buttonsname"));

                        //Create Webelement for ButtonDisplayTitle
                        //IWebElement bDisplayTitle = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[4]/input"));
                        // bDisplayTitle.SendKeys(BDispValue);
                        bDisplayTitle.SendKeys(ExcelLib.ReadData(row, "BDispValue"));

                        Thread.Sleep(1000);

                        //Create Webelement for ButtonLogo                     
                        // GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[6]/span/span/span[2]/span")).Click();
                        //PF
                        bLogo.Click();
                        //Explicit Wait
                        //Thread.Sleep(2000);
                        //driver.FindElement(By.XPath("/html/body/div[7]/div/ul/li[3]/table/tbody/tr/td[1]/div")).Click();

                        //Implicit Wait                        
                        //IList<IWebElement> cbl = GlobalDef.driver.FindElements(By.XPath("/html/body/div[7]/div/ul/li"));

                        try
                        {
                            foreach (IWebElement e in cbl)
                            {
                                if ((e.Text.ToLowerInvariant()).Contains(ExcelLib.ReadData(row, "BLogo").ToLowerInvariant()))
                                {
                                    e.Click();
                                    break;
                                }

                            }
                        }
                        catch
                        {
                            throw new NoSuchElementException("Can't find camera in Button Logo dropdown");
                        }


                        //Create Webelement for PreCondition
                        // IWebElement bPreCondition = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[8]/input"));
                        // bPreCondition.SendKeys(BPreCValue);
                        bPreCondition.SendKeys(ExcelLib.ReadData(row, "BPreCValue"));

                        //Create Webelement for NextScreen
                        bNextScreen.Click();
                        IList<IWebElement> nS1 = GlobalDef.driver.FindElements(By.XPath("//*[@id='NEXT_SCREEN_DBID_listbox']/li"));
                        try
                        {
                            foreach (IWebElement e in nS1)
                            {
                                if ((ExcelLib.ReadData(row, "NextScreen").ToLowerInvariant()).Equals(e.Text.ToLowerInvariant()))
                                {
                                    e.Click();
                                    break;
                                }

                            }
                        }
                        catch
                        {
                            throw new NoSuchElementException("Can't find" + ExcelLib.ReadData(row, "NextScreen") + " in NextScreen dropdown");
                        }

                        // IWebElement bNextScreen = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[10]/span/span/span[2]/span"));
                        //var selectElement = new SelectElement(bNextScreen);
                        //selectElement.SelectByIndex(2);
                        //PF//  bNextScreen.Click();
                        //PF Thread.Sleep(1000);
                        //GlobalDef.driver.FindElement(By.XPath(".//*[@id='NEXT_SCREEN_DBID_listbox']/li[6]")).Click();
                        //PF
                        //  bNextScreenList.Click();

                        //Create Webelement for ValueUpdate
                        //IWebElement bValueUpdate = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[12]/input"));
                        //bValueUpdate.SendKeys(BValue);
                        bValueUpdate.SendKeys(ExcelLib.ReadData(row, "BValue"));

                        //Create Webelement for NextState
                        bNextState.Click();
                        IList<IWebElement> nS = GlobalDef.driver.FindElements(By.XPath("//*[@id='NEXT_STATE_DBID_listbox']/li"));
                        try
                        {
                            foreach (IWebElement e in nS)
                            {
                                if ((ExcelLib.ReadData(row, "NextState").ToLowerInvariant()).Equals(e.Text.ToLowerInvariant()))
                                {
                                    e.Click();
                                    break;
                                }

                            }
                        }
                        catch
                        {
                            throw new NoSuchElementException("Can't find" + ExcelLib.ReadData(row, "NextState") + " in NextState dropdown");
                        }
                        //IWebElement bNextState = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[14]/span/span/span[1]"));
                        //selectElement = new SelectElement(bNextState);
                        //selectElement.SelectByIndex(2);
                        //PF
                        //bNextState.Click();
                        Thread.Sleep(1000);
                        //GlobalDef.driver.FindElement(By.XPath("//*[@id='NEXT_STATE_DBID_listbox']/li[3]")).Click();
                        //PF
                        // bNextStateList.Click();

                        //Create Webelement for PendingState
                        bPendingState.Click();
                        IList<IWebElement> pS = GlobalDef.driver.FindElements(By.XPath("//*[@id='PENDING_STATE_DBID_listbox']/li"));
                        try
                        {
                            foreach (IWebElement e in pS)
                            {
                                if ((ExcelLib.ReadData(row, "PendingState").ToLowerInvariant()).Equals(e.Text.ToLowerInvariant()))
                                {
                                    e.Click();
                                    break;
                                }

                            }
                        }
                        catch
                        {
                            throw new NoSuchElementException("Can't find" + ExcelLib.ReadData(row, "PendingState") + " in PendingState dropdown");
                        }

                        //IWebElement bPendingState = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[16]/span/span/span[2]"));
                        //Thread.Sleep(1000);
                        //PF
                        //bPendingState.Click();
                        Thread.Sleep(2000);
                        //GlobalDef.driver.FindElement(By.XPath("//*[@id='PENDING_STATE_DBID_listbox']/li[3]")).Click();
                        //PF
                        // bPendingStateList.Click();

                        //Create Webelement for Entity Type
                        GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[18]/span/span/span[2]/span")).Click();
                        IList<IWebElement> eT = GlobalDef.driver.FindElements(By.XPath("//*[@id='ETT_DBID_listbox']/li"));
                        try
                        {
                            foreach (IWebElement e in eT)
                            {
                                if ((ExcelLib.ReadData(row, "Entity Type").ToLowerInvariant()).Equals(e.Text.ToLowerInvariant()))
                                {
                                    e.Click();
                                    break;
                                }

                            }
                        }
                        catch
                        {
                            throw new NoSuchElementException("Can't find" + ExcelLib.ReadData(row, "Entity Type") + " in Entity type dropdown");
                        }
                        Thread.Sleep(1000);
                        //bEntityType.Click();
                        //Thread.Sleep(2000);
                        //GlobalDef.driver.FindElement(By.XPath("//*[@id='ETT_DBID_listbox']/li[3]")).Click();
                        //PF
                        //bEntityTypeList.Click();

                        //Create Webelement for Override theme
                        //IWebElement bOverride = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[20]/span[1]/span/span[1]"));
                        //PF // bOverride.Click();
                        IList<IWebElement> oD = GlobalDef.driver.FindElements(By.XPath("/html/body/div[12]/div/ul/li"));
                        try
                        {
                            foreach (IWebElement e in oD)
                            {
                                if ((ExcelLib.ReadData(row, "Override").ToLowerInvariant()).Equals(e.Text.ToLowerInvariant()))
                                {
                                    e.Click();
                                    break;
                                }

                            }
                        }
                        catch
                        {
                            throw new NoSuchElementException("Can't find" + ExcelLib.ReadData(row, "Override") + " in Override dropdown");
                        }
                        // Thread.Sleep(2000);
                        //GlobalDef.driver.FindElement(By.XPath("/html/body/div[12]/div/ul/li[1]")).Click();
                        //PF
                        // bOverrideList.Click();


                        //Create Webelement for Create button
                        //IWebElement CreateButton = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[27]/a[1]"));
                        CreateButton.Click();
                        Thread.Sleep(2500);
                        string ststr1r;
                        IAlert alert = GlobalDef.driver.SwitchTo().Alert();
                        ststr1r = alert.Text;
                        alert.Accept();
                        //Verifying the Newly Added record
                        if (buttonHdr.Text == "Buttons" && ststr1r.ToLowerInvariant().Contains("create record is success"))
                        {
                            //Explicit Wait for 2 sec
                            Thread.Sleep(2000);

                            //Filter button using Buttons Name
                            GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[3]/div/table/thead/tr/th[1]/a[1]/span")).Click();

                            Thread.Sleep(1000);

                            //Enter the filter value
                            GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/input[1]", ExcelLib.ReadData(row, "Buttonsname"));

                            //Click on Filter button
                            GlobalDef.ActionButton(GlobalDef.driver, "XPath", "html/body/div[5]/form/div[1]/div[2]/button[1]");
                            GlobalDef.driver.FindElement(By.XPath("//*[@id='grid']/div[5]/a[5]")).Click();
                            //string test = ExcelLib.ReadData(row, "Buttonsname");
                            //string bg = GlobalDef.driver.FindElement(By.XPath("//*[@id='grid']/div[4]/table/tbody/tr/td[1]")).Text;
                            ////buttonNameGrid.Text.Contains(test)
                            if (buttonNameGrid.Text.Equals(ExcelLib.ReadData(row, "Buttonsname")))
                            {
                                //AddNew Successful Screenshot
                                GlobalDef.SaveScreenshot(GlobalDef.driver, ExcelLib.ReadData(row, "Buttonsname") + " AddNewSuccessfulPage");

                                Console.WriteLine("Created {0} Button record successfully", ExcelLib.ReadData(row, "Buttonsname"));
                            }
                            else
                            {
                                Console.WriteLine("Login Successfully, Test Passed");
                                Console.WriteLine("Navigate to Buttons Page Successful");
                                Console.WriteLine("Create Page Open successfully");
                                Console.WriteLine("Button Name {0} is not saved correctly", ExcelLib.ReadData(row, "Buttonsname"));
                            }

                        }
                        else
                        {
                            Console.WriteLine("Login Successfully, Test Passed");
                            Console.WriteLine("Navigate to Buttons Page Successful");
                            Console.WriteLine("Create Page Open successfully");
                            Console.WriteLine("Record not created successfully, Record was already present. Please check");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Create Page not available, Test Fail");
                    }



                }
                else
                    Console.WriteLine("Buttons Page not available, Test Fail");
            }

        }
    
        
                
        public void AddButton()
        {
            // /**********************Buttons*********************************************
            //Creating ButtonsName String
            //populating the test data to collections
            ExcelLib.PopulateInCollection(@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\TestData1.xlsx", "ButtonsPage");
            
            //Create Webelement for UserInterface
            //IWebElement Uinterface = GlobalDef.driver.FindElement(By.XPath("/ html / body / div[1] / div / div[2] / ul / li[5] / a"));
            //Uinterface.Click();
            //Page Factory Definition
            Uinterface.Click();


            //Create Webelement for Buttons
            //IWebElement UButtons = GlobalDef.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[5]/ul/li[3]/a"));
            //UButtons.Click();
            //PF
            UButtons.Click();
            Thread.Sleep(1000);
            // Buttons Page Verification
            //buttonHdr = GlobalDef.driver.FindElement(By.XPath("/html/body/div[2]/h2"));
            if (buttonHdr.Text == "Buttons")
            {
                //Console.WriteLine("Login Successfully, Test Passed");
                //Console.WriteLine("Navigate to Buttons Page Successful");

                Thread.Sleep(1000);
                //Create Webelement for AddNewRecord
                //IWebElement addNew = GlobalDef.driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                //addNew.Click();
                //PF AddNew button Click
                addNew.Click();

                //Create Webelement for Create Option
                Thread.Sleep(1000);
                //IWebElement createNew = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[1]/span"));

                //Create Page Open verification                
                if (createNew.Text == "Create")
                {

                    //Create Webelement for ButtonName
                    //IWebElement bName = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[2]/input"));
                    //bName.SendKeys(Buttonsname);
                    bName.SendKeys(ExcelLib.ReadData(2, "Buttonsname"));

                    //Create Webelement for ButtonDisplayTitle
                    //IWebElement bDisplayTitle = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[4]/input"));
                    // bDisplayTitle.SendKeys(BDispValue);
                    bDisplayTitle.SendKeys(ExcelLib.ReadData(2, "BDispValue"));

                    Thread.Sleep(1000);

                    //Create Webelement for ButtonLogo                     
                    // GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[6]/span/span/span[2]/span")).Click();
                    bLogo.Click();
                    //Explicit Wait
                    //Thread.Sleep(2000);
                    //driver.FindElement(By.XPath("/html/body/div[7]/div/ul/li[3]/table/tbody/tr/td[1]/div")).Click();

                    //Implicit Wait                        
                    //IList<IWebElement> cbl = GlobalDef.driver.FindElements(By.XPath("/html/body/div[7]/div/ul/li"));

                    try
                    {
                        foreach (IWebElement e in cbl)
                        {
                            if (e.Text.Contains(ExcelLib.ReadData(2, "BLogo")))
                            {
                                e.Click();
                                break;
                            }

                        }
                    }
                    catch
                    {
                        throw new NoSuchElementException("Can't find camera in Button Logo dropdown");
                    }


                    //Create Webelement for PreCondition
                    // IWebElement bPreCondition = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[8]/input"));
                    // bPreCondition.SendKeys(BPreCValue);
                    bPreCondition.SendKeys(ExcelLib.ReadData(2, "BPreCValue"));

                    //Create Webelement for NextScreen
                    // IWebElement bNextScreen = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[10]/span/span/span[2]/span"));
                    //var selectElement = new SelectElement(bNextScreen);
                    //selectElement.SelectByIndex(2);
                    bNextScreen.Click();
                    Thread.Sleep(1000);
                    //GlobalDef.driver.FindElement(By.XPath(".//*[@id='NEXT_SCREEN_DBID_listbox']/li[6]")).Click();
                    //PF
                    bNextScreenList.Click();

                    //Create Webelement for ValueUpdate
                    //IWebElement bValueUpdate = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[12]/input"));
                    //bValueUpdate.SendKeys(BValue);
                    bValueUpdate.SendKeys(ExcelLib.ReadData(2, "BValue"));

                    //Create Webelement for NextState
                    //IWebElement bNextState = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[14]/span/span/span[1]"));
                    //selectElement = new SelectElement(bNextState);
                    //selectElement.SelectByIndex(2);
                    bNextState.Click();
                    Thread.Sleep(1000);
                    //GlobalDef.driver.FindElement(By.XPath("//*[@id='NEXT_STATE_DBID_listbox']/li[3]")).Click();
                    //PF
                    bNextStateList.Click();

                    //Create Webelement for PendingState
                    //IWebElement bPendingState = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[16]/span/span/span[2]"));
                    Thread.Sleep(1000);
                    bPendingState.Click();
                    Thread.Sleep(2000);
                    //GlobalDef.driver.FindElement(By.XPath("//*[@id='PENDING_STATE_DBID_listbox']/li[3]")).Click();
                    //PF
                    bPendingStateList.Click();

                    //Create Webelement for Entity Type
                    //IWebElement bEntityType = GlobalDef.driver.FindElement(By.XPath("html/body/div[6]/div[2]/div/div[18]/span/span/span[2]"));
                    // selectElement = new SelectElement(bEntityType);
                    //selectElement.SelectByIndex(3);
                    Thread.Sleep(1000);
                    bEntityType.Click();
                    Thread.Sleep(2000);
                    //GlobalDef.driver.FindElement(By.XPath("//*[@id='ETT_DBID_listbox']/li[3]")).Click();
                    //PF
                    bEntityTypeList.Click();

                    //Create Webelement for Override theme
                    //IWebElement bOverride = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[20]/span[1]/span/span[1]"));
                    bOverride.Click();
                    Thread.Sleep(2000);
                    //GlobalDef.driver.FindElement(By.XPath("/html/body/div[12]/div/ul/li[1]")).Click();
                    //PF
                    bOverrideList.Click();

                    /**************************Web element not identified, NOT WORKING*********************/
                    ////Create Webelement for BG Color
                    //IWebElement bBGColor = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[22]/span/span/span[2]/span"));
                    //bBGColor.Click();
                    //System.Threading.Thread.Sleep(1000);

                    //Actions action = new Actions(driver);
                    //System.Threading.Thread.Sleep(1000);
                    //IWebElement slider = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[22]/span/span/span[1]"));
                    //System.Threading.Thread.Sleep(1000);
                    //action.MoveToElement(slider, 200, 100).Click().Build().Perform();
                    //    //MoveToElement(slider,100,16).Click().Build().Perform();
                    //System.Threading.Thread.Sleep(1000);

                    //AddNew Screenshot
                    GlobalDef.SaveScreenshot(GlobalDef.driver, "AddNewPage");

                    //Create Webelement for Create button
                    //IWebElement CreateButton = GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[27]/a[1]"));
                    CreateButton.Click();
                    Thread.Sleep(2500);
                    string ststr1r;
                    IAlert alert = GlobalDef.driver.SwitchTo().Alert();
                    ststr1r = alert.Text;
                    alert.Accept();
                    //Verifying the Newly Added record

                    if (buttonHdr.Text == "Buttons" && ststr1r.ToLowerInvariant().Contains("create record is success"))
                    {
                        //Explicit Wait for 2 sec
                        Thread.Sleep(2000);
                        /********PF to be done from here*/
                        //Filter button using Buttons Name
                        GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[3]/div/table/thead/tr/th[1]/a[1]/span")).Click();

                        Thread.Sleep(1000);

                        //Enter the filter value
                        GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/input[1]", ExcelLib.ReadData(2, "Buttonsname"));

                        //Click on Filter button
                        GlobalDef.ActionButton(GlobalDef.driver, "XPath", "html/body/div[5]/form/div[1]/div[2]/button[1]");

                        //Create Webelement for Edit button in the grid
                        //editbGrid = GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr[1]/td[14]/a[1]"));

                        //Create Webelement for Delete button in the grid
                        //deletebGrid = GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr[1]/td[14]/a[2]"));

                        //Create Webelement for Buttonname in the grid
                        // buttonNameGrid = GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr/td[1]"));
                        if (buttonNameGrid.Text.ToLowerInvariant() == ExcelLib.ReadData(2, "Buttonsname").ToLowerInvariant() && editbGrid.Text == "Edit" && deletebGrid.Text == "Delete")
                        {
                            //AddNew Successful Screenshot
                            GlobalDef.SaveScreenshot(GlobalDef.driver, "AddNewSuccessfulPage");


                            Console.WriteLine("Navigate to Buttons Page Successful");
                            Console.WriteLine("Create Page Open successfully");
                            Console.WriteLine("Created new record successfully");
                            //Logging Status in Test Report
                            //ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Button Added, Test Passed");
                            SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Button Added, Test Passed");

                        }
                        else
                        {
                            Console.WriteLine("Login Successfully, Test Passed");
                            Console.WriteLine("Navigate to Buttons Page Successful");
                            Console.WriteLine("Create Page Open successfully");
                            Console.WriteLine("Button Name is not correct");
                            //Logging Status in Test Report
                            // ButtonsPageTests. for NUnit
                            SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button Name not added correctly, Test Failed");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Login Successfully, Test Passed");
                        Console.WriteLine("Navigate to Buttons Page Successful");
                        Console.WriteLine("Create Page Open successfully");
                        Console.WriteLine("Record not created successfully, Record was already present. Please check");
                        //Logging Status in Test Report
                        // ButtonsPageTests. for Nunit
                        SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button not created, it was already present, Test Failed");
                    }


                }
                else
                {
                    Console.WriteLine("Create Page not available, Test Fail");
                    //Logging Status in Test Report
                    //  ButtonsPageTests.
                    SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Create Page not available, Test Failed");
                }



            }
            else
            {
                Console.WriteLine("Buttons Page not available, Test Fail");
                //Logging Status in Test Report
                //  ButtonsPageTests.
                SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Buttons Page not available, Test Failed");
            }

        }
        //       ****************************BUTTONS Add CODE END HERE****************************************************************/





        public void EditButton()
        {

            /************************************EDIT BUTTON CODE************************************/
            //populating the test data to collections
            ExcelLib.PopulateInCollection(@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\TestData1.xlsx", "ButtonsPage");

            //Buttons Name Filter
            GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[3]/div/table/thead/tr/th[1]/a[1]/span")).Click();

            //Explicit wait
            Thread.Sleep(1000);

            //Enter the filter value
            GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/input[1]", ExcelLib.ReadData(2,"Buttonsname"));

            //Click on Filter button
            GlobalDef.ActionButton(GlobalDef.driver, "XPath", "html/body/div[5]/form/div[1]/div[2]/button[1]");

            //Defining ButtonName in the grid
            buttonNameGrid = GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr/td[1]"));

            //Finding the record to edit
            if (buttonNameGrid.Text == ExcelLib.ReadData(2, "Buttonsname"))
            {
                //Click on Edit Button
                GlobalDef.ActionButton(GlobalDef.driver, "XPath", ".//*[@id='grid']/div[4]/table/tbody/tr/td[14]/a[1]");
                //Implicit Wait
                GlobalDef.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
                //new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementExists((By.XPath("html/body/div[8]/div[1]/span"))));
                // GlobalDef.Wait(driver, "html/body/div[8]/div[1]/span");
                //Defining Modify popup
                IWebElement Modifypopup = GlobalDef.driver.FindElement(By.XPath("/html/body/div[7]/div[1]/span"));

                //Verify the Modify pop-up
                if (Modifypopup.Text == "Modify" || Modifypopup.Text == "Edit")
                {
                    //Edit Value in the modify Page
                    //Implicit Wait
                    GlobalDef.Wait(GlobalDef.driver, "/html/body/div[7]/div[2]/div/div[2]/input", "visible");

                    //Modify Webelement for ButtonName
                    GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[7]/div[2]/div/div[2]/input", ExcelLib.ReadData(3, "Buttonsname"));

                    //Implicit Wait
                    GlobalDef.Wait(GlobalDef.driver, "/html/body/div[7]/div[2]/div/div[4]/input", "visible");
                    //Modify Webelement for ButtonDisplayTitle
                    GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[7]/div[2]/div/div[4]/input", ExcelLib.ReadData(3, "BDispValue"));
                    //Thread.Sleep(1000);

                    //Modify Webelement for ButtonLogo                                                     
                    GlobalDef.driver.FindElement(By.XPath("/html/body/div[7]/div[2]/div/div[6]/span/span/span[2]/span")).Click();
                    IList<IWebElement> bL = GlobalDef.driver.FindElements(By.XPath("/html/body/div[8]/div/ul/li"));
                    try
                    {
                        foreach (IWebElement e in bL)
                        {
                            if (e.Text.Contains(ExcelLib.ReadData(3, "BLogo")))
                            {
                                e.Click();
                                break;
                            }

                        }
                    }
                    catch
                    {
                        throw new NoSuchElementException("Can't find value as " + ExcelLib.ReadData(3,"BLogo")+ "in Button Logo dropdown");
                    }

                    //GlobalDef.Wait(driver, "/html/body/div[7]/div[2]/div/div[6]/span/span/span[2]/span", "visible");
                    //driver.FindElement(By.XPath("/html/body/div[7]/div[2]/div/div[6]/span/span/span[2]/span")).Click();

                    ////Implicit Wait till element is clicked
                    //GlobalDef.Wait(driver, "/html/body/div[8]/div/ul/li[7]/table/tbody/tr/td[2]", "visible");
                    //new WebDriverWait(driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[8]/div/ul/li[7]/table/tbody/tr/td[2]"))).Click();
                    ////GlobalDef.Wait(driver, "/html/body/div[8]/div/ul/li[7]/table/tbody/tr/td[2]", "clickable");


                    //Modify Webelement for PreCondition
                    //Implicit Wait
                    //GlobalDef.Wait(driver, "/html/body/div[7]/div[2]/div/div[8]/input","visible");                            
                    GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[7]/div[2]/div/div[8]/input", ExcelLib.ReadData(3, "BPreCValue"));


                    //Modify Webelement for Entity Type                            
                    GlobalDef.driver.FindElement(By.XPath("/html/body/div[7]/div[2]/div/div[18]/span/span/span[2]/span")).Click();
                    IList<IWebElement> eT = GlobalDef.driver.FindElements(By.XPath("//*[@id='ETT_DBID_listbox']/li"));
                    try
                    {
                        foreach (IWebElement e in eT)
                        {
                            if (ExcelLib.ReadData(3, "Entity Type").Equals(e.Text))
                            {
                                e.Click();
                                break;
                            }

                        }
                    }
                    catch
                    {
                        throw new NoSuchElementException("Can't find"+ ExcelLib.ReadData(3, "Entity Type")+" in Entity type dropdown");
                    }

                    //Edit Page Screenshot
                    GlobalDef.SaveScreenshot(GlobalDef.driver, "EditPage");

                    //Create Webelement for Update button
                    GlobalDef.driver.FindElement(By.XPath("/html/body/div[7]/div[2]/div/div[27]/a[1]")).Click();
                    Thread.Sleep(1000);

                    //Verifying the Newly Edited record

                    if (buttonHdr.Text == "Buttons")
                    {
                        //Explicit Wait for 2 sec
                        Thread.Sleep(2000);

                        //Filter option using Buttons Name
                        GlobalDef.driver.FindElement(By.XPath("//*[@id='grid']/div[3]/div/table/thead/tr/th[1]/a[1]/span")).Click();

                        Thread.Sleep(1000);

                        //Enter the filter value
                        GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/input[1]", ExcelLib.ReadData(3, "Buttonsname"));

                        //Click on Filter button
                        GlobalDef.ActionButton(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/div[2]/button[1]");

                        //Create Webelement for Edit button in the grid
                        editbGrid = GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr/td[14]/a[1]"));

                        //Create Webelement for Delete button in the grid
                        deletebGrid = GlobalDef.driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr/td[14]/a[2]"));

                        //Create Webelement for Buttonname in the grid
                        //buttonNameGrid = driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr/td[1]"));
                        if (editbGrid.Text == "Edit" && deletebGrid.Text == "Delete")
                        {
                            //Edit Successful Screenshot
                            GlobalDef.SaveScreenshot(GlobalDef.driver, "EditSuccessfulPage");

                            Console.WriteLine("Record {0} edited successfully to {1}", ExcelLib.ReadData(2, "Buttonsname"), ExcelLib.ReadData(3, "Buttonsname"));
                            //Logging Status in Test Report
                            // ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Button " + ExcelLib.ReadData(2, "Buttonsname")+" edited successfully to "+ ExcelLib.ReadData(3, "Buttonsname")+ ", Test Passed");
                            SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " edited successfully to " + ExcelLib.ReadData(3, "Buttonsname") + ", Test Passed");
                        }
                        else
                        {
                            Console.WriteLine("Record {0} was not edited successfully to {0}Edit ButtonsName", Buttonsname);
                            //Logging Status in Test Report
                            //  ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is not edited successfully to " + ExcelLib.ReadData(3, "Buttonsname") + ", Test Failed");
                            SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is not edited successfully to " + ExcelLib.ReadData(3, "Buttonsname") + ", Test Failed");
                        }


                    }
                }
                else
                {
                    Console.WriteLine("Edit page not available, Test Failed");
                    //Logging Status in Test Report
                    // ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Edit Page Not Available, Test Failed");
                    SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Edit Page Not Available, Test Failed");
                }

            }
            else
            {
                Console.WriteLine("{0} record not found in the grid to edit", Buttonsname);
                //Logging Status in Test Report
                //  ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " not found in the grid to edit");
                SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Edit Page Not Available, Test Failed");
            }
            /*****************Edit Code Ends Here*************************/
        }

        public void DeleteButton()
        {
            /**********************Delete Record Code Starts here*********************/
            Thread.Sleep(1000);
            //Filter option using Buttons Name
            GlobalDef.driver.FindElement(By.XPath("//*[@id='grid']/div[3]/div/table/thead/tr/th[1]/a[1]/span")).Click();

            Thread.Sleep(1000);

            //Enter the filter value
            GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/input[1]", ExcelLib.ReadData(2, "Buttonsname"));

            //Click on Filter button
            GlobalDef.ActionButton(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/div[2]/button[1]");

            //Click Delete Button in the grid
            GlobalDef.driver.FindElement(By.XPath("//*[@id='grid']/div[4]/table/tbody/tr/td[14]/a[2]")).Click();
            GlobalDef.Wait(GlobalDef.driver, "//*[@id='container']/h2", "visible");

            //populating the test data to collections
            ExcelLib.PopulateInCollection(@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\TestData1.xlsx", "ButtonsPage");

            //Delete Page Screenshot
            GlobalDef.SaveScreenshot(GlobalDef.driver, "DeletePage1");

            //Verify navigation to Delete confirmation Page
            if (GlobalDef.driver.FindElement(By.XPath("//*[@id='container']/h3")).Text == "Are you sure you want to delete this?")
            {
                if (GlobalDef.driver.FindElement(By.XPath("//*[@id='container']/div/dl/dd[1]")).Text.Contains(ExcelLib.ReadData(2, "Buttonsname")))
                {


                    GlobalDef.driver.FindElement(By.XPath("//*[@id='container']/div/form/div/input")).Click();
                    Thread.Sleep(1000);
                    //Verifying the Newly Edited record

                    if (GlobalDef.driver.FindElement(By.XPath("//*[@id='container']/h2")).Text.Contains("Buttons"))
                    {
                        //Explicit Wait for 2 sec
                        Thread.Sleep(2000);

                        //Filter option using Buttons Name
                        GlobalDef.driver.FindElement(By.XPath("//*[@id='grid']/div[3]/div/table/thead/tr/th[1]/a[1]/span")).Click();

                        Thread.Sleep(1000);

                        //Enter the filter value
                        GlobalDef.Textbox(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/input[1]", ExcelLib.ReadData(2, "Buttonsname"));

                        //Click on Filter button
                        GlobalDef.ActionButton(GlobalDef.driver, "XPath", "/html/body/div[5]/form/div[1]/div[2]/button[1]");

                        if (GlobalDef.driver.FindElement(By.XPath("//*[@id='grid']/div[5]/span[2]")).Text.Contains("No items to display"))
                        {
                            //Delete Page Screenshot
                            GlobalDef.SaveScreenshot(GlobalDef.driver, "DeletePageSuccess");

                            Console.WriteLine("{0} record deleted successfully", ExcelLib.ReadData(2, "Buttonsname"));
                            //Logging Status in Test Report
                            //ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is deleted successfully, Test Pass ");
                            SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is deleted successfully, Test Pass ");

                        }
                        else
                        {
                            Console.WriteLine("Record not deleted succesfully");
                            //Logging Status in Test Report
                            // ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is not deleted, Test Failed ");
                            SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is not deleted, Test Failed ");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Button Name: {0} not available in Delete Page ", ExcelLib.ReadData(2, "Buttonsname"));
                    //Logging Status in Test Report
                    //ButtonsPageTests.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is not available in Delete Page, Test Failed ");
                    SpecFlow.ButtonsSpecFlowFeatureSteps.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Button " + ExcelLib.ReadData(2, "Buttonsname") + " is not available in Delete Page, Test Failed ");
                }
            }
            /********************Delete Code Ends Here**************/
        }
    }
}
