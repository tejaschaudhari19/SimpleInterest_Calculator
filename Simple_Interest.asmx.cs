using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SimpleInterest_Calculator
{
    /// <summary>
    /// Summary description for Simple_Interest
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Simple_Interest : System.Web.Services.WebService
    {

        [WebMethod]
        public float Calculator(float p,float n,float r)
        {
            return (p*n*r)/100;   
        }
    }
}
