using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class ShowTimeActionMenuItem : Interfaces.IActionMenuItem
    {
        private const string m_Name = "Show time";

        public string Name
        {
            get { return m_Name; }
        }
        

        public void DoAction()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
