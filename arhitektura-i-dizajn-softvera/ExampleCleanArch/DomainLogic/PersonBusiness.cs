using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class PersonBusiness:IPersonBusiness
    {
        private readonly IRepository<Core.Entities.Person> _repository;

        public PersonBusiness(IRepository<Core.Entities.Person> repository)
        {
            _repository = repository;
        }

        public void Add(string firstName, string lastName)
        {
            var person = new Person(firstName, lastName);
            _repository.Add(person);
        }

        public void Delete(Guid id)
        {
            var person = _repository.GetById(id);
            _repository.Delete(person);
        }

        public void Update(Guid id, string firstName, string lastName)
        {
            var person = _repository.GetById(id);
            person.Update(firstName, lastName);
            _repository.Update(person);
        }

        public IReadOnlyCollection<Core.Entities.Person> GetAllPersons()
        {
            return _repository.GetAll();
        }

        public Core.Entities.Person GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IReadOnlyCollection<Person> Search(string firstName, string lastName)
        {
            return _repository.GetAll().Where(x => x.FirstName.Contains(firstName) && x.LastName.Contains(lastName)).ToList();
        }
    }
}
