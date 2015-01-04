using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class ShowVersionActionMenuItem : Interfaces.IActionMenuItem
    {

        private const string m_Name = "Show version";

        public string Name
        {
            get { return m_Name; }
        }
        

        public void DoAction()
        {
            Console.WriteLine("Version: 15.1.4.0");
        }
    }
}
