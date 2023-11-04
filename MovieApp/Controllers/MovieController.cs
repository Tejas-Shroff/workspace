using Microsoft.AspNetCore.Mvc;
namespace MovieApp.Controllers{

    [ApiController]
    [Route("/controller")]
    public class MoviewController : controllerBase{
        MovieContext context = new MovieContext();
        [HttpGet]
        [Route("ListMovies")]
        public IActionResult Get(){
            var data = from m in context.Movies select m;

            return Ok(data);


        }
        
    }
}