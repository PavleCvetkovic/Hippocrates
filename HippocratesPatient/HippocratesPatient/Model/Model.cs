using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HippocratesPatient.Model
{
    class Model : IModel//, IValidate
    {
        //IValidate i;
        public bool ConnectToDatabase(string constring)
        {
            return true;
            throw new NotImplementedException();
        }

        public bool validateJMBG(string s)
        {
            return true;
            throw new NotImplementedException();
        }

        public bool validateLBO(string s)
        {
            return true;
            throw new NotImplementedException();
        }
    }
}
