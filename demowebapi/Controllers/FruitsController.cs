using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace demowebapi.Controllers{

    [ApiController]
    [Route("api/[Controller]")]
    public class FruitsController : ControllerBase{
        static List<string> Fruits = new List<string> { "Apple" , "Mango", "Orange", "Grapes", "Banana" };
        [HttpGet]
        [Route("showFruits")]
        public IEnumerable<string>GetFruits(){
            return Fruits;
        }
        [HttpGet]
        [Route("ShowFruits/{id}")]


        public string GetFruits(int id){
            return Fruits[id];
        }
        [HttpPost]
        [Route("Add Fruits")]
        public void Post([FromBody] string data){

            Fruits.Add(data);

        }
    }
}


