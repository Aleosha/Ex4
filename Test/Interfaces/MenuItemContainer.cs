using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class MenuItemContainer : IMenuItem
    {
        public void Add(IMenuItem i_MenuItem)
        {
            throw new NotImplementedException();
        }

        public object Show()
        {
            throw new NotImplementedException();
        }
    }
}
