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
    public class PeopleController : ControllerBase
    {
        private readonly IPersonRepository _repository;

        public PeopleController(IPersonRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IActionResult GetPeople()
        {
            return Ok(_repository.GetPeople());
        }
    }
}
