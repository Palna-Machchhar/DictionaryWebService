using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DictionaryClient
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((TextBox1.Text == "machchharpalna@gmail.com" && TextBox2.Text == "palna")|| (TextBox1.Text=="jenilmahy25@gmail.com" && TextBox2.Text == "jenil"))
            {
                string script = "alert(\"Login Successfull !!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                Response.Redirect("~/Admin.aspx");
            }
            else
            {
                string script = "alert(\"Invalid Login Credentials !!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }
    }
}