using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{

    class MyModel : IModel
    {
        static Random random = new Random();
        LinkedList<Node> nodes=new LinkedList<Node>();
        //public int Count => nodes.Count;
        public int Count { get =>nodes.Count ; }

        public void AddNode(int value)
        {
            nodes.AddFirst(new Node(value,random.Next(10),random.Next(10)));
            
        }

        public void RemoveLastNode()
        {
            nodes.RemoveLast();
        }
    }
}
