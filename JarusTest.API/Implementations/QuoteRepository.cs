using JarusTest.API.Abstractions;
using JarusTest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Implementations
{
    public class QuoteRepository : IQuoteRepository
    {
        private static readonly List<Quote> quotes;
        static QuoteRepository()
        {
            quotes = new List<Quote>()
            {
                new Quote
                {
                    QuoteId = 1,
                    QuoteNumber = "Q92348",
                    Status = StatusEnum.Issued,
                    Applicant = "Mahasoft Technologies",
                    QuoteDate = new DateTime(2020, 07, 14),
                    QuoteEffectiveDate = new DateTime(2020, 07, 20),
                    PremiumOptions = new PremiumOptions { Basic = 680, Preferred = 850, Premier = 1050 }
                },
                new Quote
                {
                    QuoteId = 2,
                    QuoteNumber = "Q973504",
                    Status = StatusEnum.Pending,
                    Applicant = "James Feather LLC",
                    QuoteDate = new DateTime(2020, 07, 14),
                    QuoteEffectiveDate = new DateTime(2020, 07, 20),
                    PremiumOptions = new PremiumOptions { Basic = 680, Preferred = 850, Premier = 1050 }
                }
            };
        }

        public List<Quote> GetQuotes()
        {
            return quotes;
        }
    }
}
