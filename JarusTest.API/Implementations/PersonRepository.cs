using JarusTest.API.Abstractions;
using JarusTest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        private static readonly List<Person> people;
        static PersonRepository()
        {
            people = new List<Person>()
            {
                new Person
                {
                    PersonId = 1,
                    Title = "Mr",
                    FirstName = "James",
                    LastName = "Feather",
                    DOB = new DateTime(1980, 3, 1)
                },
                new Person
                {
                    PersonId = 2,
                    Title = "Mr",
                    FirstName = "John",
                    LastName = "Krakow",
                    DOB = new DateTime(1980, 3, 1)
                },
                new Person
                {
                    PersonId = 3,
                    Title = "Mr",
                    FirstName = "Red",
                    LastName = "Hemmington",
                    DOB = new DateTime(1980, 3, 1)
                },
                new Person
                {
                    PersonId = 4,
                    Title = "Mr",
                    FirstName = "Ron",
                    LastName = "Eldrich",
                    DOB = new DateTime(1990, 7, 11)
                },
                new Person
                {
                    PersonId = 5,
                    Title = "Mr",
                    FirstName = "Thom",
                    LastName = "Crystal",
                    DOB = new DateTime(1979, 11, 08)
                }
            };
        }

        public List<Person> GetPeople()
        {
            return people;
        }
    }
}
