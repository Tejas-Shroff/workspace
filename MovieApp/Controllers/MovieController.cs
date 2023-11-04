using Microsoft.AspNetCore.Mvc;
namespace MovieApp.Controllers{

    [ApiController]
    [Route("/[controller]")]
    public class MovieController : ControllerBase{
        MovieContext context = new MovieContext();
        [HttpGet]
        [Route("ListMovies")]
        public IActionResult Get(){
            var data = from m in context.Movies select m;

            return Ok(data);


        }
        [HttpGet]
        [Route("ListMovies/{id}")]
        public IActionResult Get(int id){
            if(id == null){
                return BadRequest("Id cannot be null");

            }
            var data = (from m in context.Movies where m.Id == id select m ).FirstOrDefault();
            if(data == null){
                return NotFound($"Movie {id} not found");

            }
            return Ok(data);
            
        }
    }
}