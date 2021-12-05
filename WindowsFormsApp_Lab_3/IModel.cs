using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{
    internal interface IModel
    {
        void AddNode(int value);
        void RemoveLastNode();
        int Count { get; }
    }
}
