using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.Data.Models;

namespace REALtor1._2.Data.Repository
{
    public class PersonRepository : IAllPerson
    {
        private readonly DbContent dbContent;
        public PersonRepository(DbContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<Person> AllPeople => dbContent.Person;

        public void createPerson(Person person)
        {
            dbContent.Person.Add(person);
            dbContent.SaveChanges();
        }
    }
}
