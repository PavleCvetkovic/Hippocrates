using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HippocratesPatient.Model
{
    public interface IModel
    {
        bool ConnectToDatabase(string constring);
        bool validateJMBG(string s);
        bool validateLBO(string s);

    }
}
