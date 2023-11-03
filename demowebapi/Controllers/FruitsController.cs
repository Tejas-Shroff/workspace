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
        [HttpPut]
        [Route("Edit/{id}")]
        public void Put(int id,[FromBody] string data){

            Fruits[id] = data;

        }
        [HttpDelete]
        [Route("Kill/{id}")]
        public void Delete(int id){

            Fruits.RemoveAt(id);

        }


    }
}


