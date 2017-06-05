using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Model;
using Hippocrates.View;

namespace Hippocrates.Controller
{
    public interface IController
    {
        void attach(IView view, IModel model);
    }
}
