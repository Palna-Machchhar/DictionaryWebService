using System;
using System.Collections.Generic;
using System.Data;
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
            AdminReference.AdminServiceClient admin = new AdminReference.AdminServiceClient();
            AdminReference.Word[] words = admin.ShowAllWords();
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("WordId"));
            tbl.Columns.Add(new DataColumn("Title"));
            tbl.Columns.Add(new DataColumn("Meaning"));
            tbl.Columns.Add(new DataColumn("Pronunciation"));
            tbl.Columns.Add(new DataColumn("Plural"));
            tbl.Columns.Add(new DataColumn("Adjective"));
            tbl.Columns.Add(new DataColumn("Synonym"));
            tbl.Columns.Add(new DataColumn("Antonym"));
            tbl.Columns.Add(new DataColumn("ExampleSentence"));
            DataRow row;
            for (int i=0;i<words.Length;++i)
            {
                row = tbl.NewRow();
                row["WordId"] = words[i].WordId;
                row["Title"] = words[i].Title;
                row["Meaning"] = words[i].Meaning;
                row["Pronunciation"] = words[i].Pronunciation;
                row["Plural"] = words[i].Plural;
                row["Adjective"] = words[i].Adjective;
                row["Synonym"] = words[i].Synonym;
                row["Antonym"] = words[i].Antonym;
                row["ExampleSentence"] = words[i].ExampleSentence;
                tbl.Rows.Add(row);
            }
            GridView1.DataSource = tbl;
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