using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLinkedListHomework
{
    public class CircleListNode<T>
    {
        public T Data { get; set; }

        public CircleListNode<T> Next { get; set; }

        public CircleListNode<T> Previous { get; set; }

        public CircleListNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
