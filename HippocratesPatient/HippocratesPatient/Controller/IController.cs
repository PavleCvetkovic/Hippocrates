using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HippocratesPatient.Controller
{
    public interface IController
    {
        void OnLogin(); // Click event on 'Uloguj se' button
        void OnSuccessfulConnection(); // Successful connection to database

        Model.IModel GetModel();
    }
}
