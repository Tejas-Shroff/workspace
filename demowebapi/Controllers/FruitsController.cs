using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace demowebapi.Controllers;


[ApiController]
[Route("api/[Controller]")]
public class FruitsController : ControllerBase{
    static List<string> Fruits = new List<string> { "Apple" , "Mango", "Orange", "Grapes", "Banana" };
    [HttpGet]
    [Route("showFruits")]
    public IEnumerable<string>GetFruits(){
        return Fruits;
    }

    
    public string GetFruits(int id){
        return[id];
    }

}