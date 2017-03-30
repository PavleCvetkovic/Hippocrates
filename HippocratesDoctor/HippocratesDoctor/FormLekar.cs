using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippocrates.Controller;
using Hippocrates.View;
using MetroFramework.Forms;

namespace HippocratesDoctor
{
    public partial class FormLekar : MetroForm, IView
    {
        private IController _controller;
        public FormLekar()
        {
            InitializeComponent();
        }

        public void setController(IController controller)
        {
            this._controller = controller;
        }

    }
}
