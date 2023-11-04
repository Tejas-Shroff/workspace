using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
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
        [HttpPost]
        [Route("AddMovie")]
        public IActionResult Post (Movie movie){

            if(ModelState.IsValid){

                try{

                    context.Movies.Add(movie);
                    context.SaveChanges();
                    
                }
                
                catch(System.Exception ex){

                    return BadRequest(ex.InnerException.Message);

                }

            }

            return Created("Record Added", movie);

        } 
        [HttpPut]
        [Route("EditMovie/{id}")]
        public IActionResult (int id, movie movie){
            
        }
    }
}