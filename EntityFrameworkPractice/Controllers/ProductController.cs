using Microsoft.AspNetCore.Mvc;

using EntityFrameworkPractice.Models;

namespace EntityFrameworkPractice.Controllers;

public class ProductController : Controller{

    public IActionResult List(){

        return View();

    }

    public IActionResult Create(){

        return View();

    }
    [HttpPost]
    public IActionResult Create(Product P){

        var data = context.Product.Add



    }

}