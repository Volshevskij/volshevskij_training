using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thw_4._1
{
    class WordFrequencyCounter
    {
        private string Text { get; set; }

        private string[] DevidedText { get; set; }

        private List<string> UniqueWords { get; set; }

        private int[] WordCount { get; set; }

        public WordFrequencyCounter(string text)
        {

            if(String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }

            Text = text;
            UniqueWords = new List<string>();

            GetDevidedText();
            GetUniqueWords();

            WordCount = new int[UniqueWords.Count];

            GetWordCount();
        }

        public WordFrequencyCounter():this("Some text")
        {

        }

        private void GetDevidedText()
        {
            DevidedText = Text.Split(new char[] { ' ' });

            for(int i = 0; i < DevidedText.Length; i++)
            {
                DevidedText[i] = DevidedText[i].ToLower();
            }
        }

        private void GetUniqueWords()
        {
            foreach (string s in DevidedText)
            {
                bool mark = false;

                foreach (string c in UniqueWords)
                {
                    if (s.CompareTo(c) == 0)
                    {
                        mark = true;
                    }
                }

                if (mark == false)
                {
                    UniqueWords.Add(s);
                }
            }
        }

        private void GetWordCount()
        {
            for (int i = 0; i < WordCount.Length; i++)
            {
                foreach (string s in UniqueWords)
                {
                    foreach (string c in DevidedText)
                    {
                        if(s.CompareTo(c) == 0)
                        {
                            WordCount[i]++;
                        }
                    }
                    i++;
                }
            }
        }

        public string[] GetAnswer()
        {
            string[] answ = new string[UniqueWords.Count];

            for (int i = 0; i < answ.Length; i++)
            {
                answ[i] = "For <" + UniqueWords[i] + "> Count: " + WordCount[i];
            }

            return answ;
        }
    }
}
