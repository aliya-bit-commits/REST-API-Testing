using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DemoAutoFramework.Base;
using EAAutoFramework.Helpers;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using ExcelDataReader;
using System.Data;

namespace EATestAutomation
{
    [TestClass]
    public class APITest
    {
        private string getUrl = "https://sbyccdeveis-apim-team.azure-api.net/articles/v1/articles/86395";
        private string secureGetUrl = "https://sbyccdeveis-apim-team.azure-api.net/articles/v1/articles/86395";

        [TestMethod]
        public void TestUsingStatement()
        {
            var filePath = @"C:\DemoAutomation\DemoAutoFramework\EATestAutomation\DataFile\Article_Number.xlsx";
            string articleNum;
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader;

            //1. Reading Excel file
            if (Path.GetExtension(filePath).ToUpper() == ".XLS")
            {
                //1.1 Reading from a binary Excel file ('97-2003 format; *.xls)
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                //1.2 Reading from a OpenXml Excel file (2007 format; *.xlsx)
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            //2. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader.AsDataSet();

            DataTable dt = result.Tables[0];

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://sbyccdeveis-apim-team.azure-api.net");
                httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "68f3c3e8a49d4bf0ac75ebf8522e348c");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                {
                    try
                    {

                        articleNum = dt.Rows[i][0].ToString();
                        HttpResponseMessage httpResponse = httpClient.GetAsync("/articles/v1/articles/" + articleNum).Result;

                        using (HttpResponseMessage httpResponseMessage = httpResponse)
                        {
                            Console.WriteLine(httpResponseMessage.ToString());

                            //Status Code
                            HttpStatusCode statusCode = httpResponseMessage.StatusCode;

                            // Response Data 
                            HttpContent responseContent = httpResponseMessage.Content;
                            Task<string> responseData = responseContent.ReadAsStringAsync();
                            string data = responseData.Result;

                            RestResponse1 restResponse = new RestResponse1((int)statusCode, responseData.Result);
                            Console.WriteLine(restResponse.ToString());

                            Assert.AreEqual(200, restResponse.StatusCode);
                            Assert.IsNotNull(restResponse.ResponseContent);
                            JsonRootObject jsonRootObject = JsonConvert.DeserializeObject<JsonRootObject>(restResponse.ResponseContent);
                            Assert.AreEqual(articleNum, jsonRootObject.ARTICLE_NUMBER);
                            Assert.AreEqual("CS", jsonRootObject.SapUnitofmeasure[0].UNITOFMEASURE);
                            Assert.AreEqual("EA", jsonRootObject.SapUnitofmeasure[1].UNITOFMEASURE);
                        }
                    }
                    catch (AssertFailedException e)
                    {
                        Assert.Fail("Test case failed with error " + e.Message);
                    }

                }
            }
        }
    }
}
