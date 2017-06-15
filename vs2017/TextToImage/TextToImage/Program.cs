using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer;
using TheArtOfDev.HtmlRenderer.Adapters;
using TheArtOfDev.HtmlRenderer.Core;

namespace TextToImage
{
    class Program
    {
        static void Main(string[] args)
        {
            float height = 100;
            float weight = 100;
            Bitmap bmp = new Bitmap((int)weight, (int)height);
            //Graphics graphics = Graphics.FromImage(bmp);
            //Font font1 = new Font("Bookman Old Style", 100);
            //SizeF stringSize = graphics.MeasureString("版权所有cnki", font1);
            //bmp = new Bitmap(bmp, (int)stringSize.Width, (int)stringSize.Height);
            //graphics = Graphics.FromImage(bmp);
            //SolidBrush semiTransBrush1 = new SolidBrush(Color.FromArgb(9, Color.Red));
            //graphics.DrawString("版权所有cnki", font1, semiTransBrush1, 0, 0);
            //Font font = new Font("Arial", 10);
            //SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(15,Color.Blue));
            //graphics.DrawString("若要指示非特定语言，您应指定为 0 language 参数。 可用语言和子列表，请参见 Winnt.h 中的标头文件。", font, semiTransBrush,50, 0);
            //graphics.DrawString("如果您有 Visual Studio 安装，此标头文件通常找不到相对于 Visual Studio Include 安装目录。", font, semiTransBrush, 80, 30);
            //graphics.DrawString("如果您有 Visual Studio 安装，此标头文件通常找不到相对于 Visual Studio Include 安装目录。", font, semiTransBrush, 80, 60);
            //graphics.DrawString("如果您有 Visual Studio 安装，此标头文件通常找不到相对于 Visual Studio Include 安装目录。", font, semiTransBrush, 80, 90);
            //graphics.DrawString("如果您有 Visual Studio 安装，此标头文件通常找不到相对于 Visual Studio Include 安装目录。", font, semiTransBrush, 80, 120);
            //font.Dispose();
            //graphics.Flush();
            //graphics.Dispose();

//            Image image = TheArtOfDev.HtmlRenderer.WinForms.HtmlRender.RenderToImage("<div  style='background: #fff none repeat scroll 0 0; border: 1px solid #cac8c8;  font-family: 微软雅黑; height: auto;  margin: 20px auto; overflow: hidden; padding: 40px 10px 10px 35px; width: 933px;'>"+
//    "<div  style = ' height: 40px; line-height: 40px; margin: 0 auto;width: 100%; border-bottom:3px solid #1aa700;' >"+

//        "<p  style = 'float:left; width: 120px; text-align: center; display: block; height: 40px;line-height: 40px;color: #fff;font-size: 16px;border-radius: 5px 5px 0 0; background-color: #1aa700; margin:0; ' > 李雪 </p>"+
                              
//                                      "</ div >" +
//                                       "<i style = ' padding:2px 4px; border:1px solid #9fb56d;  font-style:normal;  color:rgb(159,181,109);  border-radius:4px; ' > 保障条件 </ i ><span style = ' color: #666;  display: block;float: left; font-size: 12px; height: 38px;text-align:center;width: 290px;' > 成人馆 &mdash; 省级馆  &nbsp;&nbsp;&nbsp;&nbsp;2016-03-14 15:43:12 </span >" +

//                                      "<h2 style = 'color: #1aa700;font-size: 16px; font-weight: normal; padding-top:30px;' > 评估的馆藏要求中外文量的要求是多少？</ h2 >" +
                                       
//      "<div  style = 'padding-top:25px;' ><h2 style = '  color: #1aa700;font-size: 16px;font-weight: normal; padding-top:15px;' > 回答：</ h2 ><span > 评估中对省级馆纸质外文图书的要求是10万册评估中对省级馆纸质外文图书的要求是10万册评估中对省级馆纸质外文图书的要求是10万册"+
//"评估中对省级馆纸质外文图书的要求是10万册评估中对省级馆纸质外文图书的要求是10万册评估中对省级馆纸质外文图书的要求是10万册"+
//"评估中对省级馆纸质外文图书的要求是10万册评估中对省级馆纸质外文图书的要求是10万册评估中对省级馆纸质外文图书的要求是10万册"+
//"评估中对省级馆纸质外文图书的要求是10万册评估中对省级馆纸质外文图书的要求是10万册.</ span >"+
//    "</ div ><p  style = '  color: #999; float: right; font-size: 12px; height: 45px;padding-top: 40px;width: 375px;' > 页面内容未经授权和许可，任何单位和个人不得转载、摘编或以其他"+
//    " 任何形式使用。违反上述声明者，本机构将依法追究其相关法律责任。</ p >"+
//     "</ div > ",1000,1000);
            
            string path = Environment.CurrentDirectory;
           // bmp.Save(Path.Combine(path, "123.bmp"));
        //    image.Save(Path.Combine(path, "123.png"), ImageFormat.Png);

            WebBrowser webBrowser1 = new WebBrowser();
            webBrowser1.Navigate("file:///C:/Users/NZL/Desktop/mgf.html");
           Size mySize = webBrowser1.Document.Window.Size;
            Bitmap myPic = new Bitmap(mySize.Width, mySize.Height);
            Rectangle myRec = new Rectangle(0, 0, mySize.Width, mySize.Height);
            webBrowser1.Size = mySize;
            webBrowser1.DrawToBitmap(myPic, myRec);
            myPic.Save(Path.Combine(path, "123.png"));

            Console.ReadLine();
        }
       
    }
}
