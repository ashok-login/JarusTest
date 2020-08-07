using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JarusTest.API.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JarusTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalInsuredsController : ControllerBase
    {
        private readonly IAdditionalInsuredRepository _repository;

        public AdditionalInsuredsController(IAdditionalInsuredRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IActionResult GetAllAdditionalInsureds()
        {
            return Ok(_repository.GetAdditionalInsureds());
        }
    }
}
