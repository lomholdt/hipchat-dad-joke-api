using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DadJokes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private readonly IJokeService _jokeService;

        public JokeController(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<HipChatResponse> Get()
        {
            var joke = _jokeService.getRandomJoke();

            var response = new HipChatResponse
            {
                Color = "green",
                Message = $"{joke.Question} ... {joke.Answer}",
            };

            return response;
        }
    }
}
