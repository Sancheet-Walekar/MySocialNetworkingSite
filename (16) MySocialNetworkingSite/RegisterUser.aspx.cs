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
    public partial class RegisterUser : System.Web.UI.Page
    {

        SqlConnection myconn;
        SqlCommand mycmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cvalcap_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
        }
        bool CheckPassword(String inp)
        {
            bool result = false;
            int cnt = 0;
            if(inp.Length < 8)
            {
                return result;
            }
            foreach(char c in inp)
            {
                if(c >= 'A' && c <= 'Z')
                {
                    result = true;
                    cnt++;
                    break;
                }    
            }
            foreach(char c in inp)
            {
                if(c >= 'a' && c <= 'z')
                {
                    result = true;
                    cnt++;
                    break;
                }
            }
            foreach(char c in inp)
            {
                if(c >= '0' && c <= '9')
                {
                    result = true;
                    cnt++;
                    break;
                }
            }
            if(cnt==3)
            {
                //check for special symbols
                String sym = "~!@#$%^&*_-";
                if(inp.IndexOfAny(sym.ToCharArray()) == -1)
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }       
            return result;
        }

        protected void valpwd_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String pwd = args.Value;
            args.IsValid = CheckPassword(pwd);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
                //check whether page is valid.
                if(Page.IsValid)
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SocialDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                String insSql = "insert into dbo.userDetails values(@un,@fn,@ln,@gen,@cn,@em,@pwd,@dob)";
                mycmd = new SqlCommand(insSql,myconn);
                mycmd.Parameters.AddWithValue("@un", txtusername.Text);
                mycmd.Parameters.AddWithValue("@fn", txtfn.Text);
                mycmd.Parameters.AddWithValue("@ln", txtln.Text);
                if(radmale.Checked)
                {
                    mycmd.Parameters.AddWithValue("@gen", "M");
                }
                if(radfemale.Checked)
                {
                    mycmd.Parameters.AddWithValue("@gen", "F");
                }
                mycmd.Parameters.AddWithValue("@cn", double.Parse(txtcontact.Text));
                mycmd.Parameters.AddWithValue("@em", txtemail.Text);
                mycmd.Parameters.AddWithValue("@pwd", txtpwd.Text);
                mycmd.Parameters.AddWithValue("@dob", txtdob.Text);
                //open the connect
                myconn.Open();
                int cnt = mycmd.ExecuteNonQuery();
                if(cnt>0)
                {
                    Response.Write("<script>alert('Inserted Successfully'</script>");
                }
                else
                {
                    Response.Write("<script>alert('Insertion failed'</script>");
                }
                myconn.Close();
            }
        }

        protected void cvalreg_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String entCap = args.Value;
            String gCap = Session["Cap"].ToString();
            if (entCap.Equals(gCap))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}