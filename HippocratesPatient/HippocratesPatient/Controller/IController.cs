using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HippocratesPatient.Controller
{
    public interface IController
    {
        void OnLogin();

        Model.IModel GetModel();
    }
}
