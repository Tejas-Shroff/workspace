using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Logging;
 
namespace MoviesApp.Controllers{

    [ApiController]
    [Route("/[controller]")]

    public class DetailController : ControllerBase
    {
        MovieContext context = new MovieContext();

        [HttpGet]
        [Route("DisplayMovieDetails/(id)")]
 
        public IActionResult Get(int id){

            var data = from d in context.Details where d.MovieId == id select new{
                Artist = d.Actor, Role=d.Role,MovieName=d.Movie.Name,Year = d.Movie.YearRelease};
                return Ok(data);
                
        }

        [HttpGet]
        [Route("ListDetail")]
 
        public IActionResult Get(){

            var data = from d in context.Details select new {MovieName=d.Movie.Name,Artist=d.Actor};
            return Ok(data);

        }

        [HttpGet]
        [Route("ListDetails/{id}")]
 

 
        public IActionResult Get(int? id){

            if(id==null){

                return BadRequest("Id cannot be null");

            }

            var data = (from d in context.Details where d.MovieId ==id select d).FirstOrDefault();

            if(id==null){

                return NotFound($"Detail {id} not found");
            }

            return Ok(data);
        }


         [HttpPost]
        [Route("AddDetails")]


        public IActionResult Post([FromBody] Detail detail){

            if(ModelState.IsValid){

                try{
                    
                    context.Details.Add(detail);
                    context.SaveChanges();

                }
            

                catch(System.Exception ex){

                    return BadRequest(ex.InnerException.Message);    

                      
                }

            }

            return Created("Record Added",detail);

        }

    }

}