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
                    view.Message("Učitavanje u toku...");
                    // check for JMBG and LBO in database
                    OnSuccessfulConnection();

                }
                else
                    view.Message("Greška prilikom konekcije na bazu");
            else
                view.Message("Validacija nije u redu");
            
        }

        public void OnSuccessfulConnection() // Successful connection to database
        {
            // Open new form with tabs 
            // Izbor zeljenog lekara, vakcina, dijagnostifikovano, izbor termina
            PacijentForm pacijent_form = new PacijentForm(view.GetJMBG(), view.GetLBO());

            pacijent_form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            pacijent_form.ShowDialog();
            //view.Message("Uspešno učitani podaci iz baze");
            
        }

    }
}
