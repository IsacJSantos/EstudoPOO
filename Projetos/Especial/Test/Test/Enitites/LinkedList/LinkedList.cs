using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Entities.LinkedList
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

        // Method Add on middle

        // Method Add on end

        // Method get all

        // Method get with Node
    }
}
