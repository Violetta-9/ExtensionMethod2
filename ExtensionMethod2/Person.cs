using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod2
{
    public class Person
    {
        public string NameOfClient { get; set; }
        public int Age { get; set; }
        public Person(string name, int age) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (age<13)
            {
                throw new ArgumentNullException(nameof(age));
            }
            NameOfClient = name;
            Age = age;
        }

        public Person() { }
    }
}
