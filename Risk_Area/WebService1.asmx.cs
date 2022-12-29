using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Risk_Area
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Square(double s)
        {
            return s*s;
        }

        [WebMethod]
        public double Traiangle(double b, double h)
        {
            return 0.5*b*h;
        }

        [WebMethod]
        public double Rectangle(double w, double h)
        {
            return w*h;
        }

        [WebMethod]
        public double Circle(double r)
        {
            return 3.14*r*r;
        }
    }
}
