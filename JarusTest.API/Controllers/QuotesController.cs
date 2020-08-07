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
    public class QuotesController : ControllerBase
    {
        private readonly IQuoteRepository _repository;

        public QuotesController(IQuoteRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IActionResult GetQuotes()
        {
            return Ok(_repository.GetQuotes());
        }
    }
}
