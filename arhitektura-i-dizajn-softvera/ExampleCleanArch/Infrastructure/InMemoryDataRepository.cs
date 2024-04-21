using Core;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure
{
    public class InMemoryDataRepository:IRepository<Person>
    {
        private List<Person> _people = new List<Person>();
        public InMemoryDataRepository() { }

        public void Add(Person entity)
        {
            _people.Add(entity);
        }

        public void Delete(Person entity)
        {
            _people.Remove(entity);
        }

        public IReadOnlyCollection<Person> GetAll()
        {
            return _people;
        }

        public Person GetById(Guid id)
        {
            return _people.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Person entity)
        {
            var person = _people.SingleOrDefault(x => x.Id == entity.Id);
            if (person != null)
            {
                person.Update(entity.FirstName, entity.LastName);
            }
        }
    }
}
