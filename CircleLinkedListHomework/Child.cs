using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLinkedListHomework
{
    public class Child
    {
        public int Id { get; set; }

        public Names Name { get; set; }

        public Child() { }

        public Child(int id, Names name)
        {
            Id = id;
            Name = name;
        }

        public enum Names
        {
            Rick,
            Rachel,
            Morty,
            Mary,
            Summer,
            Stanly
        }

        public static implicit operator int(Child child)
        {
            return child.Id;
        }

        public override bool Equals(object obj)
        {
            return Id == ((Child)obj).Id;
        }

        public override string ToString()
        {
            return Id.ToString() + " "  + Name.ToString();
        }
    }
}
