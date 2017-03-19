using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HippocratesPatient.View
{
    public interface IView
    {
        void AddListener(Controller.IController ic);
        string getJMBG();
        string getLBO();
        void Message(string s);
    }
}
