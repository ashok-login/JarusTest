using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
    }
}
