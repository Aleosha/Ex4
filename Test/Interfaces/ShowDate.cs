using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class ShowDate : IActionMenuItem
    {
        private const string m_Name = "Show date";

        public string Name
        {
            get { return m_Name; }
        }
        

        public void DoAction()
        {
            throw new NotImplementedException();
        }
    }
}
