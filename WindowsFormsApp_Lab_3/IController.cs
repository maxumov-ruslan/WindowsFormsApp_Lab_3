using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{
    public interface IController
    {
        IModel Model { get; set; }
        void AddView(IView view);
        void Add();
        void Remove();
    }
}
