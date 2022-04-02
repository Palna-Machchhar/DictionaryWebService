using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DictionaryClient
{
    public partial class ManageWord : System.Web.UI.Page
    {
        
        int id;
        AdminReference.AdminServiceClient admin = new
                AdminReference.AdminServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["Id"]);

                if (id == -1)
                {
                    Button1.Text = "Add";
             
                }
                else
                {
                    Button1.Text = "Edit";
                    AdminReference.Word editword = new AdminReference.Word();
                    editword = admin.GetWord(id);
                    TextBox1.Text = editword.Title;
                    TextBox2.Text = editword.Meaning;
                    TextBox3.Text = editword.Pronunciation;
                    TextBox4.Text = editword.Plural;
                    TextBox5.Text = editword.Adjective;
                    TextBox6.Text = editword.Synonym;
                    TextBox7.Text = editword.Antonym;
                    TextBox8.Text = editword.ExampleSentence;

                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["Id"]);
            if (id == -1)
            {
                AdminReference.Word addword = new AdminReference.Word();
                addword.WordId = id;
                addword.Title = TextBox1.Text.ToString();
                addword.Meaning = TextBox2.Text.ToString();
                addword.Pronunciation = TextBox3.Text;
                addword.Plural = TextBox4.Text;
                addword.Adjective = TextBox5.Text;
                addword.Synonym = TextBox6.Text;
                addword.Antonym = TextBox7.Text;
                addword.ExampleSentence = TextBox8.Text;

                admin.AddWord(addword);
                Response.Redirect("~/Admin.aspx");
            }
            else
            { 
                AdminReference.Word editword = new AdminReference.Word();
                editword.WordId = id;
                editword.Title = TextBox1.Text.ToString();
                editword.Meaning = TextBox2.Text.ToString();
                editword.Pronunciation = TextBox3.Text;
                editword.Plural = TextBox4.Text;
                editword.Adjective = TextBox5.Text;
                editword.Synonym = TextBox6.Text;
                editword.Antonym = TextBox7.Text;
                editword.ExampleSentence = TextBox8.Text;
                
                admin.EditWord(editword);
                Response.Redirect("~/Admin.aspx");
            }

        }
    }
}