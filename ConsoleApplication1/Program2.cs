using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program2
    {

        private void Buttons()
        {
            //Intialization definition
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Launch URL

            driver.Navigate().GoToUrl("https://demo.econz.co.nz:1000/AdminPortal/Account/Login/exptest");

            //Create Webelement for Username
            IWebElement uname = driver.FindElement(By.Id("UserName"));
            uname.SendKeys("jiya");

            //Create Webelement for Password
            IWebElement pwd = driver.FindElement(By.Id("Password"));
            pwd.SendKeys("Jiya@345");

            //Create Webelement for Login button
            IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[3]/form/div/div/div/div[2]/div[3]/input"));
            LoginButton.Click();

            //Login Verification
            IWebElement Welcome = driver.FindElement(By.XPath("//*[@id='container']/div/div/h2"));

            //  string Welcometxt = Welcome.Text;
            if (Welcome.Text == "Welcome")
            {
                //Console.WriteLine("Login Successfully, Test Passed");

                //Creating ButtonsName String
                string Buttonsname = "RtestName1";
                //Create Webelement for UserInterface
                IWebElement Uinterface = driver.FindElement(By.XPath("/ html / body / div[1] / div / div[2] / ul / li[5] / a"));
                Uinterface.Click();


                //Create Webelement for Buttons
                IWebElement UButtons = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[5]/ul/li[3]/a"));
                UButtons.Click();
                System.Threading.Thread.Sleep(1000);
                // Buttons Page Verification
                IWebElement buttonHdr = driver.FindElement(By.XPath("/html/body/div[2]/h2"));
                if (buttonHdr.Text == "Buttons")
                {
                    //Console.WriteLine("Login Successfully, Test Passed");
                    //Console.WriteLine("Navigate to Buttons Page Successful");

                    System.Threading.Thread.Sleep(1000);
                    //Create Webelement for AddNewRecord
                    IWebElement addNew = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                    addNew.Click();

                    //Create Webelement for Create Option
                    System.Threading.Thread.Sleep(1000);
                    IWebElement createNew = driver.FindElement(By.XPath("/html/body/div[6]/div[1]/span"));

                    //Create Page Open verification                
                    if (createNew.Text == "Create")
                    {

                        //Create Webelement for ButtonName
                        IWebElement bName = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[2]/input"));
                        bName.SendKeys(Buttonsname);

                        //Create Webelement for ButtonDisplayTitle
                        IWebElement bDisplayTitle = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[4]/input"));
                        bDisplayTitle.SendKeys("RtestDisplayTitle");
                        System.Threading.Thread.Sleep(1000);
                        //Create Webelement for ButtonLogo                     
                        IWebElement bLogo = driver.FindElement(By.XPath("html/body/div[6]/div[2]/div/div[6]/span/span/span[2]/span"));
                        bLogo.Click();
                        System.Threading.Thread.Sleep(2000);

                        driver.FindElement(By.XPath("/html/body/div[7]/div/ul/li[3]/table/tbody/tr/td[1]/div")).Click();

                        //var selectElement1 = new SelectElement(driver.FindElement(By.XPath("html/body/div[7]/div/ul")));
                        //selectElement1.SelectByIndex(2);


                        //Create Webelement for PreCondition
                        IWebElement bPreCondition = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[8]/input"));
                        bPreCondition.SendKeys("RtestPrecondition");

                        //Create Webelement for NextScreen
                        IWebElement bNextScreen = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[10]/span/span/span[2]/span"));
                        //var selectElement = new SelectElement(bNextScreen);
                        //selectElement.SelectByIndex(2);

                        bNextScreen.Click();
                        System.Threading.Thread.Sleep(2000);
                        driver.FindElement(By.XPath(".//*[@id='NEXT_SCREEN_DBID_listbox']/li[6]")).Click();

                        //Create Webelement for ValueUpdate
                        IWebElement bValueUpdate = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[12]/input"));
                        bValueUpdate.SendKeys("RtestValueUpdate");

                        //Create Webelement for NextState
                        IWebElement bNextState = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[14]/span/span/span[1]"));
                        //selectElement = new SelectElement(bNextState);
                        //selectElement.SelectByIndex(2);

                        bNextState.Click();
                        System.Threading.Thread.Sleep(2000);
                        driver.FindElement(By.XPath("//*[@id='NEXT_STATE_DBID_listbox']/li[3]")).Click();

                        //Create Webelement for PendingState
                        IWebElement bPendingState = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[16]/span/span/span[2]"));
                        System.Threading.Thread.Sleep(1000);
                        bPendingState.Click();
                        System.Threading.Thread.Sleep(2000);
                        driver.FindElement(By.XPath("//*[@id='PENDING_STATE_DBID_listbox']/li[3]")).Click();

                        //Create Webelement for Entity Type
                        IWebElement bEntityType = driver.FindElement(By.XPath("html/body/div[6]/div[2]/div/div[18]/span/span/span[2]"));
                        // selectElement = new SelectElement(bEntityType);
                        //selectElement.SelectByIndex(3);
                        System.Threading.Thread.Sleep(1000);
                        bEntityType.Click();

                        System.Threading.Thread.Sleep(2000);
                        driver.FindElement(By.XPath("//*[@id='ETT_DBID_listbox']/li[3]")).Click();

                        //Create Webelement for Override theme
                        IWebElement bOverride = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[20]/span[1]/span/span[1]"));
                        bOverride.Click();
                        System.Threading.Thread.Sleep(2000);
                        driver.FindElement(By.XPath("/html/body/div[12]/div/ul/li[1]")).Click();

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

                        ////Create Webelement for Color
                        //IWebElement bColor = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[24]/span/span/span[2]/span"));
                        //bColor.Click();
                        //System.Threading.Thread.Sleep(1000);
                        //driver.FindElement(By.XPath("//*[@id='964319a6 - 4584 - 4848 - 87d7 - 640b90fc04da']/div[3]/div/div/a")).Click();

                        ////Create Webelement for Border Color
                        //IWebElement bBorderColor = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[26]/span/span/span[2]/span"));
                        //bBorderColor.Click();
                        //System.Threading.Thread.Sleep(3000);
                        //driver.FindElement(By.XPath("//*[@id='861eef67 - de0a - 4b54 - 9590 - a83ce91caccc']/div[2]/div[2]")).Click();

                        /***************************************************************/

                        //Create Webelement for Create button
                        IWebElement CreateButton = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[27]/a[1]"));
                        CreateButton.Click();
                        System.Threading.Thread.Sleep(5000);
                        string ststr1r;
                        IAlert alert = driver.SwitchTo().Alert();
                        ststr1r = alert.Text;
                        alert.Accept();

                        if (buttonHdr.Text == "Buttons" && ststr1r.ToLowerInvariant().Contains("create record is success"))
                        {
                            //Create Webelement for Edit button in the grid
                            IWebElement editbGrid = driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr[1]/td[14]/a[1]"));

                            //Create Webelement for Delete button in the grid
                            IWebElement deletebGrid = driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr[1]/td[14]/a[2]"));

                            //Create Webelement for Buttonname in the grid
                            IWebElement buttonNameGrid = driver.FindElement(By.XPath(".//*[@id='grid']/div[4]/table/tbody/tr[1]/td[1]"));
                            if (buttonNameGrid.Text == Buttonsname && editbGrid.Text == "Edit" && deletebGrid.Text == "Delete")
                            {
                                Console.WriteLine("Login Successfully, Test Passed");
                                Console.WriteLine("Navigate to Buttons Page Successful");
                                Console.WriteLine("Create Page Open successfully");
                                Console.WriteLine("Created new record successfully");
                            }
                            else
                            {
                                Console.WriteLine("Login Successfully, Test Passed");
                                Console.WriteLine("Navigate to Buttons Page Successful");
                                Console.WriteLine("Create Page Open successfully");
                                Console.WriteLine("Button Name is not correct");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Login Successfully, Test Passed");
                            Console.WriteLine("Navigate to Buttons Page Successful");
                            Console.WriteLine("Create Page Open successfully");
                            Console.WriteLine("Record not created successfully, Test Failed");
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
            else
                Console.WriteLine("Login Failed, Test Fail");



        }
    }
}
