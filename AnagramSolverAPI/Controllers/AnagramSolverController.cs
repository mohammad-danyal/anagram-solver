using AnagramSolverAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System;
using System.Collections.Generic;

namespace AnagramSolverAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnagramSolverController : ControllerBase
    {
        private readonly IAnagramSolver _solver;

        public AnagramSolverController(IAnagramSolver solver)
        {
            _solver = solver ?? throw new System.ArgumentNullException(nameof(solver));
        }

        [HttpGet("GetAnagrams/{word}", Name = "GetAnagrams")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [OpenApiOperation("GetAnagrams")]
        public IActionResult GetAnagrams(string word)
        {
            if (String.IsNullOrWhiteSpace(word))
            {
                BadRequest("Bad Request: No word has been specified");
            }
            var anagrams = _solver.FindAnagrams(word);

            if (anagrams is null) 
            {
                return NotFound();
            } else { 
                return Ok(anagrams);
            }            
        }
    }
}
