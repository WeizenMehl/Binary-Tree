using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_Tree
{
    internal class Node
    {
        public int _value {get; set;}
        public Node _right { get;set; }
        public Node _left { get; set; }
        public Node(int value) 
        {
            _value = value;
        }

        public override string ToString()
        {
            return $"{_value},";
        }

    }
}
