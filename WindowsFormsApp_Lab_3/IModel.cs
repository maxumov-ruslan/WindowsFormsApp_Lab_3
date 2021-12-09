using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{
    public interface IModel
    {
        
        event Action Changed;
        LinkedList<Node> AllNodes { get; }




        void AddNode(int value);
        void RemoveLastNode();
        int Count { get; }
        void RemoveNode(Node node);

    }
}





































//в интрефейсе только событие,методы,свойства;