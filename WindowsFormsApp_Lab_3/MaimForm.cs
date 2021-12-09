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
            {
                panelView1 = new PanelView();

                myDataGridView1 = new MyDataGridView();

                InitializeComponent();

                IView labView = new LabelView(label1);
                model = new MyModel();

                myDataGridView1.Model = model;
                AddView(myDataGridView1);

                labView.Model = model;
                AddView(labView);

                panelView1.Model = model;
                panelView1.NodeClicked += PanelView1_NodeClicked;
                AddView(panelView1);


            }
        }

        private void PanelView1_NodeClicked(Node node)
        {
            model.RemoveNode(node);
        }

        public IModel Model { get { return model; } set { model = value; } }


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
