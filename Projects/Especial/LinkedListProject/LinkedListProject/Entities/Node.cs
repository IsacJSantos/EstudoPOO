using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject.Entities
{
    class Node<T>
    {
        private T Value;
        private Node<T> Next;

        public Node(T value)
        {
            Value = value;
        }

        public void SetValue(T value)
        {
            Value = value;
        }

        public T GetValue()
        {
            return Value;
        }

        public void SetNext(Node<T> next)
        {
            Next = next;
        }

        public Node<T> GetNext()
        {
            return Next;
        }

    }
}
