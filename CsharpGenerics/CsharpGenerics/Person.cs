using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGenerics
{
    public class Person
    {
        public Person(string cnp)
        {
            Cnp = cnp;
        }

        public string Cnp { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
