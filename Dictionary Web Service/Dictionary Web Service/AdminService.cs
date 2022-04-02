using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

namespace Dictionary_Web_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminService" in both code and config file together.
    public class AdminService : IAdminService
    {
        static string strcon = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=DictionaryDB;Integrated Security=True";
        SqlConnection conn = new SqlConnection(strcon);
        public string AddWord(Word w)
        {
            string message;
            conn.Open();
            string query = "Insert Into Word(Title,Meaning,Pronunciation,Plural,Adjective,Synonym,Antonym,ExampleSentence) Values(@Title,@Meaning,@Pronunciation,@Plural,@Adjective,@Synonym,@Antonym,@ExampleSentence)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", w.Title);
            cmd.Parameters.AddWithValue("@Meaning", w.Meaning);
            cmd.Parameters.AddWithValue("@Pronunciation", w.Pronunciation);
            cmd.Parameters.AddWithValue("@Plural", w.Plural);
            cmd.Parameters.AddWithValue("@Adjective", w.Adjective);
            cmd.Parameters.AddWithValue("@Synonym", w.Synonym);
            cmd.Parameters.AddWithValue("@Antonym", w.Antonym);
            cmd.Parameters.AddWithValue("@ExampleSentence", w.ExampleSentence);

            int result = cmd.ExecuteNonQuery();
            if(result==1)
            {
                message = "Word Added successfully";
            }
            else
            {
                message = "Error On Insertion";
            }
            return message;
        }

        public string DeleteWord(int id)
        {
            string message;
            conn.Open();
            string query = "Delete From Word where Id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                message = "Word Deleted successfully";
            }
            else
            {
                message = "Error On Deletion";
            }
            return message;
        }

        public Word GetWord(int id)
        {
            conn.Open();
            string query = "Select * from Word where Id = " + id  ;
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
                w.ExampleSentence = rdr.GetString(8);
            }

            return w;
        }
        public string EditWord(Word w)
        {
            string message;
            conn.Open();
            string query = "Update Word Set Title=@Title,Meaning=@Meaning,Pronunciation=@Pronunciation,Plural=@Plural,Adjective=@Adjective,Synonym=@Synonym,Antonym=@Antonym,ExampleSentence=@ExampleSentence where Id='"+w.WordId+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", w.Title);
            cmd.Parameters.AddWithValue("@Meaning", w.Meaning);
            cmd.Parameters.AddWithValue("@Pronunciation", w.Pronunciation);
            cmd.Parameters.AddWithValue("@Plural", w.Plural);
            cmd.Parameters.AddWithValue("@Adjective", w.Adjective);
            cmd.Parameters.AddWithValue("@Synonym", w.Synonym);
            cmd.Parameters.AddWithValue("@Antonym", w.Antonym);
            cmd.Parameters.AddWithValue("@ExampleSentence", w.ExampleSentence);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                message = "Word Edited successfully";
            }
            else
            {
                message = "Error On Updation";
            }
            return message;
        }

        public List<Word> ShowAllWords()
        {
            List<Word> list = new List<Word>();
            conn.Open();
            string query = "Select * from Word";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                Word w = new Word();
                w.WordId = rdr.GetInt32(0);
                w.Title = rdr.GetString(1);
                w.Meaning = rdr.GetString(2);
                w.Pronunciation = rdr.GetString(3);
                w.Plural = rdr.GetString(4);
                w.Adjective = rdr.GetString(5);
                w.Synonym = rdr.GetString(6);
                w.Antonym = rdr.GetString(7);
                w.ExampleSentence = rdr.GetString(8);

                list.Add(w);
            }
            return list;
        }
    }
}
