using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public abstract class MenuItem
    {
        protected string m_ItemName;

        public MenuItem(string i_ItemName)
        {
            m_ItemName = i_ItemName;
        }

        public string ItemName
        {
            get { return m_ItemName; }
            //set { m_ItemName = value; }
        }

        public abstract void Choose();

    }
}
