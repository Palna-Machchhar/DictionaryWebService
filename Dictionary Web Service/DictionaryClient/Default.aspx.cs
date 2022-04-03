using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DictionaryClient
{
    public partial class Default : System.Web.UI.Page
    {
        public bool flag = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DictionaryReference.DictionaryServiceClient dictionary = new
                DictionaryReference.DictionaryServiceClient();
            var word = dictionary.SearchWord(TextBox1.Text.ToString());
            
            if(word.Title != "" )
            {
                flag = true;
                Label2.Text = word.Title.ToString();
                Label3.Text = word.Meaning.ToString();
                Label4.Text = word.Pronunciation.ToString();
                Label5.Text = word.Plural.ToString();
                Label6.Text = word.Adjective.ToString();
                Label7.Text = word.Synonym.ToString();
                Label8.Text = word.Antonym.ToString();
                Label9.Text = word.ExampleSentence.ToString();
                Label1.Text = "";

            }
            else
            {
                flag = false;
                Label1.Text = "Word Not Found :("; 
            }
        }
    }
}