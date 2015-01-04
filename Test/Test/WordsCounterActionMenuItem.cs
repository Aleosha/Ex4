using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class WordsCounterActionMenuItem : Interfaces.IActionMenuItem
    {

        private const string m_Name = "Words counter";

        public string Name
        {
            get { return m_Name; }
        }
        

        public void DoAction()
        {
            char[] wordsSeparator = { ' ' };
            int numOfWords;
            Console.WriteLine("Please enter a sentence for counting it's number of words");
            string sentence = Console.ReadLine();
            numOfWords = sentence.Split(wordsSeparator).Length;
            Console.WriteLine("Your sentence contains {0} words", numOfWords);
        }
    }
}
