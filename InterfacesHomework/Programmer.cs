﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Programmer : IDeveloper,IComparable
    {
        public string Tool { get ; set; }

        public string Language { get; set; }

        public Programmer()
        {
            Tool = "Programmer tool";

            Language = "C#";
        }

        public void Create()
        {
            Console.WriteLine("Programmer create");
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer destroy");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is IDeveloper programmer)
                return Tool.CompareTo(programmer.Tool);
            else
                throw new ArgumentException("Object is not a programmer");
        }     
    }
}
