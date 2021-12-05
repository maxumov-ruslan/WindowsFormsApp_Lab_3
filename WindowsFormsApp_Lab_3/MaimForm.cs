using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab_3
{
    public partial class MaimForm : Form,IController
    {
        public MaimForm()
        {
            InitializeComponent();
            Model =new MyModel();
        }
        static Random random = new Random();
        List<IView> views = new List<IView>();
        IModel model;
        public IModel Model { get ; set ; }

        public void Add()
        {
            Model.AddNode(Model.Count + 1);
            model.AddNode(random.Next(100));
        }

        public void AddView(IView view)
        {
            views.Add(view);
        }

        public void Remove()
        {
            Model.RemoveLastNode();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}
