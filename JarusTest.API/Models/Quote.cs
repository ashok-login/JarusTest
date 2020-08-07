using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string QuoteNumber { get; set; }
        public StatusEnum Status { get; set; }
        public string Applicant { get; set; }
        public DateTime QuoteDate { get; set; }
        public DateTime QuoteEffectiveDate { get; set; }
        public PremiumOptions PremiumOptions { get; set; }
    }
}
