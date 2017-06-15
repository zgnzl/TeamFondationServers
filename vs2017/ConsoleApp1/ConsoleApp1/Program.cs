using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static string url = ConfigurationSettings.AppSettings["url"];
        static string loadfile = ConfigurationSettings.AppSettings["loadfile"];
        static string urlparam = ConfigurationSettings.AppSettings["urlparam"];
        static int cachecnt =int.Parse(ConfigurationSettings.AppSettings["cachecnt"]);
        static int viewcnt = int.Parse(ConfigurationSettings.AppSettings["viewcnt"]);
        static bool lockbool = bool.Parse(ConfigurationSettings.AppSettings["lock"]);
        static WebClient webc = new WebClient();
        static Bitmap m_Bitmap;
        static void Main(string[] args)
        {
         
           
            webc.Encoding = Encoding.UTF8;
            int i = 100000;
            int cachecount = 0;
            do
            {
                try
                {
                   // string urlcontent = webc.DownloadString(url +"/"+ urlparam + (i++).ToString());
                    //cachecount = HandelContent(urlcontent, i);

                    //.......
                    Thread m_thread = new Thread(new ParameterizedThreadStart(HtmlToImg));
                     m_thread.SetApartmentState(ApartmentState.STA);
                     m_thread.Start(url + "/" + urlparam + (i++).ToString());
                     m_thread.Join();

                }
                catch(Exception e)
                {
                    Console.WriteLine("count:{0};cathc{1}",i,cachecount);
                    cachecount++;
                }

            } while (lockbool&&cachecount < cachecnt && i< viewcnt);
            Console.WriteLine("2001".GetMessage());
            Console.Read();
        }

        private static void HtmlToImg(object url)
        {
            WebBrowser m_WebBrowser = new WebBrowser();
            m_WebBrowser.ScrollBarsEnabled = false;
            m_WebBrowser.Navigate("http://www.cnblogs.com/warioland/archive/2011/10/13/2210545.html");
            m_WebBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser_DocumentCompleted);
                        while (m_WebBrowser.ReadyState != WebBrowserReadyState.Complete)
                            Application.DoEvents();
                        m_WebBrowser.Dispose();

        }

        private static  void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
         {
             WebBrowser m_WebBrowser = (WebBrowser)sender;
             m_WebBrowser.ClientSize = new Size(1000,5000);
             m_WebBrowser.ScrollBarsEnabled = false;
             Bitmap m_Bitmap = new Bitmap(m_WebBrowser.Bounds.Width, m_WebBrowser.Bounds.Height);
             m_WebBrowser.BringToFront();
             m_WebBrowser.DrawToBitmap(m_Bitmap, m_WebBrowser.Bounds);
             m_Bitmap = (Bitmap) m_Bitmap.GetThumbnailImage(m_WebBrowser.Bounds.Width, m_WebBrowser.Bounds.Height, null, IntPtr.Zero);
            m_Bitmap.Save(loadfile + DateTime.Today.ToBinary() + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }


    private static int HandelContent(string content,int i)
        {
            if(!content.Contains(ErrorMessageCode.GetMessage("9000")))
            {
            string StrPage = content;
            Regex re = new Regex("<img( ||.*?)file=('|\"|)([^\"|^\']+)('|\"|>| )", RegexOptions.IgnoreCase);
            MatchCollection matches = re.Matches(StrPage);
                int j = 0;
            foreach (Match mh in matches)
            {
               string tmpImageUrl = url+"/"+ mh.Groups[3].Value;//src里面的路径
                    webc.DownloadFile(tmpImageUrl, loadfile + (i+"_"+j++)+ tmpImageUrl.Substring(tmpImageUrl.LastIndexOf('.')));
            }
            }
            return 0;
        }
    }
    public static class ErrorMessageCode
    {
        public static string GetMessage(this string code)
        {
            try
            {
                switch (code)
                {
                    case "1000": return "您没有权限，进行此操作！";
                    case "2000": return "操作{0}失败！";
                    case "2001": return "<span style='color:red'>{0}</span>添加成功!";
                    case "9000": return "对不起，您还未登录，无权访问该版块";
                    default: return "未知原因操作失败，请联系管理员!";
                }
            }
            catch (Exception e) { return e.Message; }
        }
    }

  
}
