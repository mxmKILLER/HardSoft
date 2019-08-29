using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Builder : IDeveloper, IComparable
    {
        public string Tool { get; set; }

        public Builder()
        {
            Tool = "Builder tool";
        }

        public void Create()
        {
            Console.WriteLine("Builder create");
        }

        public void Destroy()
        {
            Console.WriteLine("Builder destroy");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is IDeveloper builder)
                return Tool.CompareTo(builder.Tool);
            else
                throw new ArgumentException("Object is not a builder");
        }
    }
}
