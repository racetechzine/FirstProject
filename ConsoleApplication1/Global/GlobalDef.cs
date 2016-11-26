
using Excel;
using ICSharpCode;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProj
{
    class GlobalDef
    {
        //Initialization of Common/Global Driver
        public static IWebDriver driver { get; set; }

        public static void Textbox(IWebDriver driver, string Locator, string Lvalue, string InputValue)
        {
            if (Locator == "Id")
            {
                driver.FindElement(By.Id(Lvalue)).Clear();
                driver.FindElement(By.Id(Lvalue)).SendKeys(InputValue);
            }
            else if (Locator == "XPath")
            {
                driver.FindElement(By.XPath(Lvalue)).Clear();
                driver.FindElement(By.XPath(Lvalue)).SendKeys(InputValue);
            }
            else if (Locator == "CSS")
            {
                driver.FindElement(By.XPath(Lvalue)).Clear();
                driver.FindElement(By.CssSelector(Lvalue)).SendKeys(InputValue);
            }
            else
                Console.WriteLine("Invalid Locator value");

        }

        public static void ActionButton(IWebDriver driver, string Locator, string Lvalue)
        {
            if (Locator == "Id")
                driver.FindElement(By.Id(Lvalue)).Click();
            else if (Locator == "XPath")
                driver.FindElement(By.XPath(Lvalue)).Click();
            else if (Locator == "CSS")
                driver.FindElement(By.CssSelector(Lvalue)).Click();
            else
                Console.WriteLine("Invalid Locator value");
        }
        public static string SaveScreenshot(IWebDriver driver, string ScreenshotFileName)
        {
            var folderlocation = (@"C:\Users\ReshNikesh\Desktop\Study\Testing\SeleniumPrac\FirstProj\Screenshot\");
            if (!System.IO.Directory.Exists(folderlocation))
            {
                System.IO.Directory.CreateDirectory(folderlocation);
            }
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            var filename = new StringBuilder(folderlocation);
            //filename Append
            filename.Append(ScreenshotFileName);
            filename.Append(DateTime.Now.ToString("_dd-mm-yyyy-mss"));
            filename.Append(".jpeg");
            screenshot.SaveAsFile(filename.ToString(), System.Drawing.Imaging.ImageFormat.Jpeg);
            return filename.ToString();

            }

        public static bool Wait(IWebDriver driver, string XpathValue, string condition)
        {
            if (condition.ToLowerInvariant() == "visible")
                new WebDriverWait(driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath(XpathValue))));
           // else if (condition.ToLowerInvariant() == "clickable")
           //     //new WebDriverWait(driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementToBeClickable(By.XPath(XpathValue))).Click();
           //// new WebDriverWait(driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible(By.XPath(XpathValue))).Click();
           // else
           //     Console.WriteLine("Invalid Wait Condition");

            //    //WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(0));
            //    //wait.Until(ExpectedConditions.ElementExists((By.XPath(XpathValue))));
            return true;
        }
    }

    public class ExcelLib
    {
        static List<Datacollection> dataCol = new List<Datacollection>();

        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }


        public static void ClearData()
        {
            dataCol.Clear();
        }


        private static DataTable ExcelToDataTable(string fileName, string SheetName)
        {
            // Open file and return as Stream
            using (FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                {
                    excelReader.IsFirstRowAsColumnNames = true;

                    //Return as dataset
                    DataSet result = excelReader.AsDataSet();
                    //Get all the tables
                    DataTableCollection table = result.Tables;

                    // store it in data table
                    DataTable resultTable = table[SheetName];

                    //excelReader.Dispose();
                    //excelReader.Close();
                    // return
                    return resultTable;
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations

                rowNumber = rowNumber - 1;
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                // var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).Select(x=> x.colValue).FirstOrDefault().ToList();


                return data.ToString();
            }

            catch (Exception e)
            {
                //Added by Kumar
                Console.WriteLine("Exception occurred in ExcelLib Class ReadData Method!" + Environment.NewLine + e.Message.ToString());
                return null;
            }
        }

        public static void PopulateInCollection(string fileName, string SheetName)
        {
            ExcelLib.ClearData();
            DataTable table = ExcelToDataTable(fileName, SheetName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };


                    //Add all the details for each row
                    dataCol.Add(dtTable);

                }
            }

        }
    }

}
