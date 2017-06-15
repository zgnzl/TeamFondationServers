using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TPI.Web.UI.WebControls;

namespace KNS60
{
    class Program
    {
        static void Main(string[] args)
        {
            TPINewSearchCtrl TPINewSearchCtrl1 = new TPINewSearchCtrl();
            string dest = "";
            TPINewSearchCtrl1.GetSqlForNoSearch("ASP.brief_singleresult_aspx", out dest, true);

            Console.Read();
        }
    }
}
