using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Lab_3
{
    public  class Node
    {
        int x, y, value;

        public Node(int x, int y, int value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Node node &&
                   x == node.x &&
                   y == node.y &&
                   value == node.value;
        }

        public override int GetHashCode()
        {
            int hashCode = 1502599509;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + value.GetHashCode();
            return hashCode;
        }
    }
}
