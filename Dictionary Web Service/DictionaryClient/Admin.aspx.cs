using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DictionaryClient
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                AdminReference.AdminServiceClient admin = new
                AdminReference.AdminServiceClient();
                var words = admin.ShowAllWords();
                GridView1.DataSource = words;
                GridView1.DataBind();
            
        }

        protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            
                if (e.CommandName == "EditWord")
                {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                Response.Redirect("~/ManageWord.aspx?Id=" + index);
                }
                else if (e.CommandName == "DeleteWord")
                {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                
                AdminReference.AdminServiceClient admin = new
                   AdminReference.AdminServiceClient();

                admin.DeleteWord(index);
                Response.Redirect("~/Admin.aspx");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = -1;
            Response.Redirect("~/ManageWord.aspx?Id=" + id );
        }
    }
}