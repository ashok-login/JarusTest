using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Models
{
    public class AdditionalInsured
    {
        public int AdditionalInsuredId { get; set; }
        public int QuoteId { get; set; }
        public int PersonId { get; set; }
        public virtual Quote Quote { get; set; }
        public virtual Person Person { get; set; }
    }
}
