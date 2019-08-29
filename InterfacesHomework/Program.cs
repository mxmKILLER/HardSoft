using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloper[] developers = new IDeveloper[4];
            Random rnd = new Random();
            int random = 0;
            for (int i = 0; i < developers.Length; i++)
            {
                random = rnd.Next(0,2);

                if (random == 0)
                {
                    developers[i] = new Programmer();
                }
                else
                {
                    developers[i] = new Builder();
                }
            }

            foreach (var item in developers)
            {
                Console.WriteLine(item.Tool);
                item.Create();
                item.Destroy();
            }

            Array.Sort(developers);

            foreach (var item in developers)
            {
                Console.WriteLine(item.Tool);
                item.Create();
                item.Destroy();
            }
        }
    }
}

/*
 vCreate interface IDeveloper with property Tool, methods Create() and Destroy()
vCreate two classes Programmer (with field language) and Builder (with field tool), which implement this interface.
vCreate array of IDeveloper and add some Programmers and Builders to it. Call Create() and Destroy() methods, property Tool for all of it
vImplement interface IComparable for clases and sort array of IDeveloper
     */
