using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class WordsCounter : IActionMenuItem
    {

        private const string m_Name = "Words counter";

        public string Name
        {
            get { return m_Name; }
        }
        

        public void DoAction()
        {

        }
    }
}
