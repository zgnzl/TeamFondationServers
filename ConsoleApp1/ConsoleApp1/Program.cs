
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "2',5'-寡腺苷酸合成酶"; //"2',5'-寡腺苷酸合成酶";// "2',5'-寡腺苷酸聚合酶";
            SearchUtility.ISearchDAL UTIL = new SearchUtility.SearchExactDAL();
            var ss= UTIL.do_Search_Mesh(s);
          
            Console.Read();
        }
    }
}
