using JarusTest.API.Abstractions;
using JarusTest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Implementations
{
    public class AdditionalInsuredRepository : IAdditionalInsuredRepository
    {
        private static readonly List<AdditionalInsured> additionalInsureds;

        static AdditionalInsuredRepository()
        {
            Quote quote1 = (new QuoteRepository()).GetQuotes().FirstOrDefault(x => x.QuoteId == 1);
            var person4 = (new PersonRepository()).GetPeople().FirstOrDefault(x => x.PersonId == 4);
            var person5 = (new PersonRepository()).GetPeople().FirstOrDefault(x => x.PersonId == 5);

            additionalInsureds = new List<AdditionalInsured>()
            {
                new AdditionalInsured
                {
                    AdditionalInsuredId = 1,
                    Quote = quote1,
                    Person = person4
                },
                new AdditionalInsured
                {
                    AdditionalInsuredId = 2,
                    Quote = quote1,
                    Person = person5
                }
            };
        }

        public List<AdditionalInsured> GetAdditionalInsureds()
        {
            return additionalInsureds;
        }
    }
}
