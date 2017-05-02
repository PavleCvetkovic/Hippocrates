using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippocratesDoctor
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
            //Application.Run(new FormLogin());
            //Application.Run(new FormDirektor("1236549877899"));
            Application.Run(new FormLekar("0112955445023"));
            //Application.Run(new FormVakcine("0106940168994"));
        }
    }
}
