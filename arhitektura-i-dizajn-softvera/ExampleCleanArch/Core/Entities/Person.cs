using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Person
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        public string FullName => $"{FirstName} {LastName}";

        public Person(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            if(string.IsNullOrEmpty(firstName)) throw new ArgumentNullException(nameof(firstName));
            FirstName = firstName;
            if(string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(lastName));
            LastName = lastName;
        }

        public void Update(string firstName, string lastName)
        {
            if(string.IsNullOrEmpty(firstName)) throw new ArgumentNullException(nameof(firstName));
            FirstName = firstName;
            if(string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(lastName));
            LastName = lastName;
        }
        public override string ToString()=>
            $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}";
    }
}
