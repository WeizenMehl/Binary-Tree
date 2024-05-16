using System;

namespace binary_Tree
{
    internal class BinaryTree
    {
        private Node _head;

        public BinaryTree()
        {
            _head = null;
        }

        public void ADD(Node n)
        {
            if (_head == null)
            {
                _head = n;
            }
            else
            {
                AddValue(_head, n);
            }
        }

        public override string ToString()
        {
            return BinaryTreeToString(_head);
        }

        private string BinaryTreeToString(Node temp)
        {
            string s = string.Empty;
            if (temp != null)
            {
                s += BinaryTreeToString(temp._left);
                s += temp.ToString();
                s += BinaryTreeToString(temp._right);
            }
            return s;
        }

        private void AddValue(Node temp, Node n)
        {
            if (n._value <= temp._value)
            {
                if (temp._left == null)
                {
                    temp._left = n;
                }
                else
                {
                    AddValue(temp._left, n);
                }
            }
            else
            {
                if (temp._right == null)
                {
                    temp._right = n;
                }
                else
                {
                    AddValue(temp._right, n);
                }
            }
        }
    }
}
