using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPersonBusiness
    {
        void Add(string firstName, string lastName);
        void Delete(Guid id);
        void Update(Guid id, string firstName, string lastName);
        IReadOnlyCollection<Person> GetAllPersons();
        Person GetById(Guid id);
        IReadOnlyCollection<Person> Search(string firstName,string lastName);
    }
}
