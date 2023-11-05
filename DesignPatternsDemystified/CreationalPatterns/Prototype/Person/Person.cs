using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.Prototype.Person
{
    public class Person : IDeepCopyable<Person>
    {
        public string Name;
        public Address Address;

        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }


        public Person DeepCopy()
        {

            var copy = new Person("Mario Rossi",
                Address.DeepCopy());

            return copy;
        }
    }


}
