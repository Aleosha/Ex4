using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void DoActionDelegate(int i_Action);
    public delegate void FinishedActionDelegate();

    public class ActionItem : MenuItem
    {
        private int m_Action;
        private DoActionDelegate m_DoActionDelegate;
        private FinishedActionDelegate m_FinishedActionDelegate;

        public ActionItem(int i_Action, string i_Name):base(i_Name)
        {
            m_Action = i_Action;
        }

        public void AttachDoActionObserver(DoActionDelegate i_ObserverDelegate)
        {
            m_DoActionDelegate += i_ObserverDelegate;
        }

        public void DetachDoActionObserver(DoActionDelegate i_ObserverDelegate)
        {
            m_DoActionDelegate -= i_ObserverDelegate;
        }

        public void AttachFinishedActionObserver(FinishedActionDelegate i_ObserverDelegate)
        {
            m_FinishedActionDelegate += i_ObserverDelegate;
        }

        public void DetachFinishedActionObserver(FinishedActionDelegate i_ObserverDelegate)
        {
            m_FinishedActionDelegate -= i_ObserverDelegate;
        }

        public override void Choose()
        {
            Console.Clear();
            if(m_DoActionDelegate != null)
            {
                m_DoActionDelegate.Invoke(m_Action);
            }
        }
    }
}
