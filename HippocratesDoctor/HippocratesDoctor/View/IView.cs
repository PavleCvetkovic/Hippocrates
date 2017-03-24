using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Controller;
namespace Hippocrates.View
{
    interface IView
    {
        void setController(IController controller);
    }
}
