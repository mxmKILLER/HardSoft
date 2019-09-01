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
            //CircleList<Child> list = new CircleList<Child>();

            //for (int i = 0; i < 5; i++)
            //{
            //    list.Add(new Child(i, (Child.Names)(i % 6)));
            //}

            //list.Delete(new Child() {Id = 3});

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            RemoveKid(10, 18);    
        }

        private static void RemoveKid(int numOfKids,int numOfWords)
        {
            CircleList<Child> list = new CircleList<Child>();

            for (int i = 0; i < numOfKids; i++)
            {
                list.Add(new Child(i, (Child.Names)(i % 6)));
            }

            while (numOfKids != 1)
            {
                int removeIndex = numOfWords % numOfKids;
                numOfKids--;
                var item = list.GetByIndex(removeIndex);
                list.RemoveItem(item);
            }
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
