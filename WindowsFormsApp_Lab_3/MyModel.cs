using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{

    public class MyModel : IModel
    {
        static Random r = new Random();
        public event Action Changed;

        LinkedList<Node> nodes=new LinkedList<Node>();
        //public int Count => nodes.Count;
        public int Count { get =>nodes.Count ; }

        //public IEnumerable<Node> AddNodes => nodes;

        public LinkedList<Node> AllNodes => nodes;


        public void RemoveLastNode()
        {
            nodes.RemoveLast();
            if (Changed != null) Changed();
        }

        public void AddNode(int value)
        {
            nodes.AddFirst(new Node(value, r.Next(10), r.Next(10)));
            if (Changed != null) Changed();
        }

        public void RemoveNode(Node node)
        {
            nodes.Remove(node);
            if (Changed != null) Changed();
        }

        
    }
}
