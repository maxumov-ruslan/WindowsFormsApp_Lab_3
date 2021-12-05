using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab_3
{
    public class PanelView : Panel, IView
    {
        public IModel Model { get ; set ; }

        public void UpdateView()
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Node n in Model.AddNodes)
            {
                g.DrawRectangle(Pens.Red, n.X * 20, n.Y * 20, 15, 15);
            }

        }
    }
}
