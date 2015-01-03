using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class ShowVersion : IActionMenuItem
    {

        private const string m_Name = "Show version";

        public string Name
        {
            get { return m_Name; }
        }
        

        public void DoAction()
        {
            Console.WriteLine("15.1.4.0");
        }
    }
}
