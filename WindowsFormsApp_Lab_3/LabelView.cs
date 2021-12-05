using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{
    public class LabelView : IView
    {
        public IModel Model { get; set ; }

        public void UpdateView()
        {
            throw new NotImplementedException();
        }
    }
}
