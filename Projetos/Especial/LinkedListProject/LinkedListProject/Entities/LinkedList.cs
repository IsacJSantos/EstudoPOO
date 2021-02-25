using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject.Entities
{
    class LinkedList<T>
    {
        private Node<T> Head;

        public void Add(T value) 
        {
            Node<T> node = new Node<T>(value);
            node.SetNext(Head);
            Head = node;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");

            Node<T> p = Head;
            while (p != null)
            {
                sb.Append(p.GetValue() + " ");
                p = p.GetNext();
            }

            sb.Append("]");

            return sb.ToString();
        }
    }
}
