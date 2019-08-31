using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLinkedListHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveKid(10, 15);    
        }

        private static void Deletion(CircleList<Child> list,int num)
        {
            var current = list.Head.Next;
            if (list.Head.Data.Id == num)
            {
                list.Delete(list.Head.Data);
                return;
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (current.Data.Id.Equals(num))
                    {
                        list.Delete(current.Data);
                    }
                    current = current.Next;
                }
            }
        }

        private static void RemoveKid(int numOfKids,int numOfWords)
        {
            CircleList<Child> list = new CircleList<Child>();
            List<int> idList = new List<int>();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (int i = 0; i < numOfKids; i++)
            {
                list.Add(new Child(i, (Child.Names)(i % 6)));
                idList.Add(i);
            }

            while (numOfKids != 1)
            {
                int removeIndex = Math.Abs(numOfWords % numOfKids);
                numOfKids--;
                Deletion(list, idList[removeIndex]);
                idList.RemoveAt(removeIndex);
            }
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
