using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class ShowDateActionMenuItem : Interfaces.IActionMenuItem
    {
        private const string m_Name = "Show date";

        public string Name
        {
            get { return m_Name; }
        }
        

        public void DoAction()
        {
            Console.WriteLine(DateTime.Now.ToString("d/M/yyyy"));
        }
    }
}
