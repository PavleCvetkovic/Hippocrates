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
            string jmbg = view.GetJMBG();
            string lbo = view.GetLBO();

            if (model.ValidateJMBG(jmbg) && model.ValidateLBO(lbo))
                if (model.ConnectToDatabase(constring))
                {
                    view.Message("Connected to database");
                    // check for JMBG and LBO in database
                    OnSuccessfulConnection();

                }
                else
                    view.Message("Error during database connection");
            else
                view.Message("Validation not okay");
            
        }

        public void OnSuccessfulConnection() // Successful connection to database
        {
            // Open new form
            AppointmentForm appointment_view = new AppointmentForm();
            
            appointment_view.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            appointment_view.Show();
        }

    }
}
