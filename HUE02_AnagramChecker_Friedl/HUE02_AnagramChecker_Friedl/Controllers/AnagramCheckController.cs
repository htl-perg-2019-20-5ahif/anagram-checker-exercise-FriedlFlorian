using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HUE02_AnagramChecker_Friedl.Controllers
{
    [Route("api/checkAnagram")]
    [ApiController]
    public class checkAnagramController : ControllerBase
    {
        // GET: api/AnagramCheck
        [HttpGet]
        public IActionResult CheckAnagram([FromBody]Words words)
        {
            string word1 = words.word1;
            string word2 = words.word2;

            Boolean check = words.CheckAnagram(word1, word2);

            if (check)
            {
                return Ok(word1 + " and " + word2 + " are an anagram");
            }
            return BadRequest(word1 + " and " + word2 + " are not an anagram");
        }

        
    }
}
