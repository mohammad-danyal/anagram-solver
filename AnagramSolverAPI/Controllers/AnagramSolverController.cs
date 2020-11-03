using Anagram.Solver;
using AnagramSolverAPI.Models;
using Microsoft.AspNetCore.Mvc;
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
            _solver = solver;
        }


        [HttpGet("GetAnagrams/{word}")]
        public List<Pair> GetAnagrams(string word)
        {
            return _solver.FindAnagrams(word);
        }
    }
}
