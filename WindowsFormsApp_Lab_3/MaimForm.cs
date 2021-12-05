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

        static Random random = new Random();
        List<IView> views = new List<IView>();
        IModel model;
        
        public MaimForm()
        {
            InitializeComponent();
            Model =new MyModel();
            LabelView v = new LabelView(label1);
            v.Model = this.Model;
            AddView(v);
        }
        public IModel Model { get; set; }
       

        

        private void UpdateAll()
        {
            //views.ForEach(view =>view.UpdateView());
            foreach(IView view in views)
            {
                view.UpdateView();
            }
        }

        public void AddView(IView view)
        {
            
            views.Add(view);
            view.UpdateView();
        }
        public void Add()
        {
            Model.AddNode(Model.Count + 1);
            UpdateAll();
        }
        public void Remove()
        {
            Model.RemoveLastNode();
            UpdateAll();
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
