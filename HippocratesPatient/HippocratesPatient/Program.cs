using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HippocratesPatient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 view = new Form1();
            Model.Model model = new Model.Model(view); // Model has a reference to view
            Controller.IController controller = new Controller.Controller(model, view); // Controller has a reference to Model AND View

            Application.Run(view);
        }
    }
}
