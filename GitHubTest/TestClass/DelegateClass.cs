using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest.TestClass
{
    public class DelegateClass
    {
        public delegate int AddActionEventHandler(int _num1, int _num2);
        public event AddActionEventHandler AddActionEvent;

        public delegate void ShowActionEventHandler(int _num1, int _num2);
        public event ShowActionEventHandler ShowActionEvent;

        public void AddAction()
        {
            if(AddActionEvent != null)
            {
                AddActionEvent(1, 2);
            }
        }

        public void ShowAction()
        {
            if(ShowActionEvent!=null)
            {
                ShowActionEvent(3, 4);
            }
        }
    }
}
