using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HippocratesPatient.Model;
using HippocratesPatient.View;
namespace HippocratesPatient.Controller
{
    class Controller : IController
    {
        IModel model;
        IView view;
        
        public Controller(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
            this.view.AddListener(this);
        }

        public IModel GetModel()
        {
            return model;
        }

        public void OnLogin()
        {
            string constring = "";
            string jmbg = view.getJMBG();
            string lbo = view.getLBO();
            if (model.validateJMBG(jmbg) && model.validateLBO(lbo))
                if (model.ConnectToDatabase(constring))
                    view.Message("Connected");
                else
                    view.Message("Error during connection");
            else
                view.Message("Validation not okay");
        }
    }
}
