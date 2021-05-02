using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestAutomation
{
    public class RestResponse1
    {
        private int statusCode;
        private string responseData;

        public RestResponse1(int statusCode, string responseData)
        {
            this.statusCode = statusCode;
            this.responseData = responseData;
        }
        public int StatusCode
        {
            get
            {
                return statusCode;
            }
        }

        public string ResponseContent
        {
            get
            {
                return responseData;
            }
        }
        public override string ToString()
        {
            return String.Format("StatsCode:{0} ResponseData :{1}", statusCode, responseData);
        }
    }
}
