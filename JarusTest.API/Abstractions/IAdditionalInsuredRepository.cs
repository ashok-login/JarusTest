using JarusTest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarusTest.API.Abstractions
{
    public interface IAdditionalInsuredRepository
    {
        List<AdditionalInsured> GetAdditionalInsureds();
    }
}
