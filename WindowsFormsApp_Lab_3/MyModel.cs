using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{

    public class MyModel : IModel
    {
        static Random random = new Random();

        LinkedList<Node> nodes=new LinkedList<Node>();
        //public int Count => nodes.Count;
        public int Count { get =>nodes.Count ; }

        public IEnumerable<Node> AddNodes => nodes;

        public void AddNode(int value)
        {
            Node n = new Node(value, random.Next(10), random.Next(10));
            nodes.AddFirst(n);
            //nodes.AddFirst(new Node(value, random.Next(10), random.Next(10)));

        }

        public void RemoveLastNode()
        {
            if (nodes.Count >0)
            {
                nodes.RemoveFirst();
            }
            
        }
    }
}
