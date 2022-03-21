using System;

namespace CsharpGenerics
{
    public class Person : IEquatable<Person>
    {
        public Person()
            : this("Not-Specified-Cnp")
        {
        }

        public Person(string cnp)
        {
            Cnp = cnp;
        }

        public string Cnp { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine($"Person: {FirstName} {LastName}, CNP: {Cnp}");
        }

        public bool Equals(Person other)
        {
            return string.Equals(Cnp, other?.Cnp, StringComparison.Ordinal) &&
                   string.Equals(FirstName, other?.FirstName, StringComparison.Ordinal) &&
                   string.Equals(LastName, other?.LastName, StringComparison.Ordinal);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Cnp, FirstName, LastName);
        }

        public static bool operator ==(Person obj1, Person obj2)
        {
            if (obj1 is null && obj2 is null)
            {
                // both are null
                return true;
            }

            if (obj1 is null || obj2 is null)
            {
                // one is null, the other is not null
                return false;
            }

            // both are not null
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Person obj1, Person obj2)
        {
            if (obj1 is null && obj2 is null)
            {
                // both are null
                return false;
            }

            if (obj1 is null || obj2 is null)
            {
                // one is null, the other is not null
                return true;
            }

            // both are not null
            return !obj1.Equals(obj2);
        }
    }
}
