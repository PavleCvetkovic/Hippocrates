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
        string GetJMBG();
        string GetLBO();
        void Message(string s);
    }
}
