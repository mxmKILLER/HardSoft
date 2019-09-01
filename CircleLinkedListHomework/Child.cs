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

        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Name.GetHashCode();
            return hashCode;
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is Child child &&
        //           Id == child.Id &&
        //           Name == child.Name;
        //}
    }
}
