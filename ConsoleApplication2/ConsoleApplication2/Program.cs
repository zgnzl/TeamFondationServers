using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CNKI.Overseas.Court.Data;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s= "<?xml version = '1.0' encoding='gbk'?>"+
            //    "<Text Total = '1' >"+
            //    "<S R = '212' ><![CDATA[在出现至少两种情形的加重事由时, 例如入户抢劫并致人重伤的, 可以被判处无期徒刑。]]></S >"+
            //    "<S R = '202' ><![CDATA[在如入户抢劫并致人重伤的, 可以被判处无期徒刑。]]></S >" +
            //    "</Text > ";
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(s);
           // XmlNodeList nodes = doc.GetElementsByTagName("S");

            string ss = DESCrypt.Encrypt("asfasdfsdf", "lczl2014");
            string sss = DESCrypt.Decrypt(ss, "lczl2014");
        }
    }
}
