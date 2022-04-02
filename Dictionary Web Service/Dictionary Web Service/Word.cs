using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Web_Service
{
    [DataContract]
    public class Word
    {
        private int Id;
        private string title = "";
        private string meaning = "";
        private string pronunciation = "";
        private string plural = "";
        private string adjective = "";
        private string synonym = "";
        private string antonym = "";
        private string exampleSentence = "";

        [DataMember]
        public int WordId
        {
            get { return Id; }
            set { Id = value; }
        }

        [DataMember]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [DataMember]
        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }
        [DataMember]
        public string Pronunciation
        {
            get { return pronunciation; }
            set { pronunciation = value; }
        }
        [DataMember]
        public string Plural
        {
            get { return plural; }
            set { plural = value; }
        }
        [DataMember]
        public string Adjective
        {
            get { return adjective; }
            set { adjective = value; }
        }
        [DataMember]
        public string Synonym
        {
            get { return synonym; }
            set { synonym = value; }
        }
        [DataMember]
        public string Antonym
        {
            get { return antonym; }
            set { antonym = value; }
        }
        [DataMember]
        public string ExampleSentence
        {
            get { return exampleSentence; }
            set { exampleSentence = value; }
        }
    }
}
