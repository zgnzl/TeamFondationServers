using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using html2image.Controllers;

namespace htmltoimg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int BrowserWidth1; int BrowserHeight1; int ThumbnailWidth1; int ThumbnailHeight1;
            BrowserWidth1 =int.Parse(BrowserWidth.Text); 
             BrowserHeight1 = int.Parse(BrowserHeight.Text);
            ThumbnailWidth1 = int.Parse(ThumbnailWidth.Text);
            ThumbnailHeight1 = int.Parse(ThumbnailHeight.Text);
           // for(int i = 0; i <= 100; i++) {
            create(BrowserWidth1, BrowserHeight1, ThumbnailWidth1, ThumbnailHeight1,"gt_"+1);
            ///   }
            button1.Enabled = true;
        }
        private void create(int BrowserWidth, int BrowserHeight, int ThumbnailWidth, int ThumbnailHeight,string name) {
            //Uri UrlString = new Uri(@"http://192.168.20.58/gfwd/culture.html?id=1");
            //WebBrowser MyControl = new WebBrowser();
            //MyControl.Size = new Size(990, 810);
            //MyControl.Url = UrlString;
            //while (MyControl.ReadyState != WebBrowserReadyState.Complete)
            //{
            //    Application.DoEvents();
            //}
            //MyControl.Height = MyControl.Document.Body.ScrollRectangle.Height + 20;
            //MyControl.Url = UrlString;
            //toImage.Snapshot snap = new toImage.Snapshot();
            //Bitmap MyImage = snap.TakeSnapshot(MyControl.ActiveXInstance, new Rectangle(0, 0, MyControl.Width, MyControl.Height));

            //MyControl.Dispose();
            //string path = Environment.CurrentDirectory;
            //MyImage.Save(Path.Combine(path, "123.bmp"));

            Bitmap m_Bitmap = WebSnapshotsHelper.GetWebSiteThumbnail("https://www.baidu.com/?tn=80035161_1_dg", BrowserWidth, BrowserHeight, ThumbnailWidth, ThumbnailHeight); //宽高根据要获取快照的网页决定
            //Graphics graphics = Graphics.FromImage(m_Bitmap);
            //Font font1 = new Font("Bookman Old Style", 60);
            //SolidBrush semiTransBrush1 = new SolidBrush(Color.FromArgb(9, Color.Red));
            //graphics.DrawString("版权所有cnki", font1, semiTransBrush1, 0, 0);
            
            //font1.Dispose();
            //graphics.Flush();
            //graphics.Dispose();
            string path = Environment.CurrentDirectory;
            m_Bitmap.Save(Path.Combine(path, "gt", name + ".bmp"));
        }

    }
}
