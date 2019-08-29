using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Builder : IDeveloper
    {
        public string Tool { get ; set ; }

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
            IDeveloper builder = obj as IDeveloper;
            if (builder != null)
                return String.Compare(this.Tool, builder.Tool);
            else
                throw new ArgumentException("Object is not a builder");
        }
    }
}
