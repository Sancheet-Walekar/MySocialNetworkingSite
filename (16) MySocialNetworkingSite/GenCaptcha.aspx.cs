using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace RegisterUserV1
{
    public partial class GenCaptcha : System.Web.UI.Page
    {
        public String GenerateCap()
        {
            String allText = "qwertyuiopasdfghjklmnbvcxzMNBVCXZASDFGHJKLPOIUYTREWQ6574839201";
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            for(int i=0;i<6;i++)
            {
                int temp = rnd.Next(allText.Length);
                sb.Append(allText[temp]);
            }
            return sb.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text= GenerateCap();
            Bitmap bmp = new Bitmap(130, 80);
            Font myFont = new Font("Moontype Corsiva", 20, FontStyle.Strikeout);
            Graphics g = Graphics.FromImage(bmp); //graphics is an object which allows all the tools for drawing
            g.Clear(Color.LightYellow);
            String cap = GenerateCap();
            // create a session and store captcha
            Session["cap"] = cap;
            Pen p1 = new Pen(Color.Red, 20);
            g.DrawRectangle(p1, 0, 0, 130, 80);
            g.DrawString(cap, myFont, Brushes.Black, 15, 25);

            bmp.Save(Response.OutputStream, ImageFormat.Gif);
        }
    }
}