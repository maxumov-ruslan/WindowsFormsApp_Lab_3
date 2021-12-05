using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab_3
{
    public class LabelView : IView
    {
        public IModel Model { get; set ; }
        Label l;

        public LabelView(Label l)
        {
            this.l = l;
        }

        public void UpdateView()
        {
            l.Text = $"N={Model.Count}";
        }
    }
}
