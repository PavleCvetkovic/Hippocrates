using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Controller;
using Hippocrates.Model;
using Hippocrates.View;

namespace HippocratesDoctor.Controller
{
    public class ControllerAdministrator : IController
    {
        private IView _view;
        private IModel _model;

        public void attach(IView view, IModel model)
        {
            this._view = view;
            this._model = model;
        }
    }
}
