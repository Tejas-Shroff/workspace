using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers;

public class DealerControllers : Controller {
    private readonly ApplicationDbContext context;

    public DealerControllers(ApplicationDbContext _context){
        context=_context;
    }

    public IActionResult List(){
        return View();
    }
    public IActionResult Create()[
         
    ]

}

