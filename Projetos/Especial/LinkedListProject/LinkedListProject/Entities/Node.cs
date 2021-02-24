using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject.Entities
{
    class Node
    {
        private double Value;
        private Node Next;

        public Node(double value)
        {
            Value = value;
        }

        public void SetValue(double value)
        {
            Value = value;
        }

        public double GetValue()
        {
            return Value;
        }

        public void SetNext(Node next)
        {
            Next = next;
        }

        public Node GetNext()
        {
            return Next;
        }

    }
}
