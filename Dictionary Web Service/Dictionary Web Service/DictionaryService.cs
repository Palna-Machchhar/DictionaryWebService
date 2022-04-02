using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

namespace Dictionary_Web_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DictionaryService : IDictionaryService
    {
        
    public Word SearchWord(string title)
        {
            string strcon = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=DictionaryDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            
            string query = "Select * from Word where Title = '" + title + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            Word w = new Word();
            while (rdr.Read())
            {
                w.WordId = rdr.GetInt32(0);
                w.Title = rdr.GetString(1);
                w.Meaning = rdr.GetString(2);
                w.Pronunciation = rdr.GetString(3);
                w.Plural = rdr.GetString(4);
                w.Adjective = rdr.GetString(5);
                w.Synonym = rdr.GetString(6);
                w.Antonym = rdr.GetString(7);
                w.ExampleSentence= rdr.GetString(8);
            }
          
            return w; 
        }
    }
}
