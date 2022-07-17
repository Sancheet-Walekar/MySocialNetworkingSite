using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MySocialNetworkingSite
{
    public partial class Index : System.Web.UI.Page
    {
        SqlConnection myconn;
        SqlCommand mycmd;
        SqlDataReader myrdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SocialDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            myconn.Open();
            String mysql = "select * from UserDetails where Username = @un and Pwd = @pwd";
            mycmd = new SqlCommand(mysql, myconn);
            mycmd.Parameters.AddWithValue("@un", txtun.Text);
            mycmd.Parameters.AddWithValue("@pwd", txtpwd.Text);
            myrdr = mycmd.ExecuteReader();
            if (myrdr.HasRows)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Response.Redirect("~/RegisterUser.aspx");
            }
        }
    }
}