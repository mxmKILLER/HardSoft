using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLinkedListHomework
{
    public class CircleList<T> : IEnumerable
    {
        public CircleListNode<T> Head { get; set; }

        public int Count { get; set; }

        public CircleList()
        {

        }

        public CircleList(T data)
        {
            SetHead(data);
        }

        public void Add(T data)
        {     
            if (Head == null)
            {
                SetHead(data);
                return;
            }
            else
            {
                var current = new CircleListNode<T>(data);
                current.Next = Head;
                current.Previous = Head.Previous;
                Head.Previous.Next = current;
                Head.Previous = current;
                Count++;
            }
        }

        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;
                return;
            }

            var current = Head.Next;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(data) && current != null)
                {
                    RemoveItem(current);
                }
                current = current.Next;
            }
        }

        private void RemoveItem(CircleListNode<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
        }

        private void SetHead(T data)
        {
            Head = new CircleListNode<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
