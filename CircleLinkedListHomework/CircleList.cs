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

        public int Count { get; set; } = 0;

        public CircleList()
        {
            Head = null;
            Count = 0;
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

        public CircleListNode<T> GetByIndex(int index)
        {
            var result = new CircleListNode<T>();
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                {
                    result = current;
                    break;
                }
                current = current.Next;
            }
            return result;
        }

        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
               // Head = Head.Next;
                return;
            }

            var current = Head.Next;
            for (int i = 0; i < Count; i++)
            {
                if (current != null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                }
                current = current.Next;
            }
        }

        public void RemoveItem(CircleListNode<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            if (current.Equals(Head))
            {
                Head = Head.Next;
            }
            Count--;
        }

        private void SetHead(T data)
        {
            Head = new CircleListNode<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count++;
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
