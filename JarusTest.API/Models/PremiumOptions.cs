using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Models
{
    public struct PremiumOptions
    {
        public decimal Basic { get; set; }
        public decimal Preferred { get; set; }
        public decimal Premier { get; set; }
    }
}
