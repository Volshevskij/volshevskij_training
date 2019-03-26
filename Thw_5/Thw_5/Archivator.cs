using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thw_4._1;

namespace Thw_5
{
    class Archivator
    {
        private string Text { get; set; }

        private static List<char> Alphabet { get; set; }

        private static List<char> CurrentUse { get; set; }

        private static List<string> Words { get; set; }

        WordFrequencyCounter fk;

        public Archivator(string text)
        {
            if(String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }

            Text = text;

            fk = new WordFrequencyCounter(Text);

            Words = fk.UniqueWords;

            Alphabet = new List<char>();

            CurrentUse = new List<char>();
        }

        public Archivator():this("Nothing")
        {

        }

        public void GetTextFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                Text = sr.ReadToEnd();
            }

            if (String.IsNullOrEmpty(Text))
            {
                throw new ArgumentNullException();
            }

            fk = new WordFrequencyCounter(Text);

            Words = fk.UniqueWords;

            Alphabet = new List<char>();

            CurrentUse = new List<char>();
        }

        public void CreateAlphabet()
        {
            for(int i = 33; i < 20000; i++)
            {
                Alphabet.Add((char)(i));               
            }
        }

        public string Archivate()
        {
            string archive = "";

            List<string> uniqueWords = fk.UniqueWords;

            int[] counts = fk.WordCount;

            for(int i = 0; i < counts.Length; i++)
            {
                CurrentUse.Add(Alphabet[i]);
            }

            string[] SplittedText = Text.Split(new char[] { ' ' });

            for (int i = 0; i < Words.Count; i++)
            {
                for (int k = 0; k < SplittedText.Length; k++)
                { 
                    if (Words[i].CompareTo(SplittedText[k]) == 0)
                    {
                        SplittedText[k] = Convert.ToString(CurrentUse[i]);
                        archive += SplittedText[k] + " ";
                    }
                }
            }
            
            return archive;
        }

        public string UnArchivate(string s)
        {
            string answ = "";
            var split = s.Split(new char[] { ' ' });

            for(int i = 0; i < split.Count(); i++)
            {
                for (int k = 0; k < Words.Count; k++)
                {
                    if (split[i].CompareTo(Convert.ToString(CurrentUse[k])) == 0)
                    {
                        split[i] = Words[k];
                        answ += split[i] + " ";
                    }
                }
            }

            return answ;
        }
    }
}
