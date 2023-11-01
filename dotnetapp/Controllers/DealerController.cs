using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;


namespace dotnetapp.Controllers;

public class DealerControllers : Controller {
    private readonly ApplicationDbContext context;

    public DealerControllers(ApplicationDbContext _context){
        context= _context;
    }

    public IActionResult Index(){
        var data = context.Dealer.ToList();
        return View();
    }
    public IActionResult Create(){
        return View();
    }
    [HttpPost]
    public IActionResult Create(Dealer d){
        if(ModelState.IsValid){
            context.Dealer.Add(d);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        return View();
    }
    public IActionResult Delete(int ID){
        // var data = context.Dealer.Find(ID);
        return View();
    }
    [HttpPost]
    public IActionResult Delete(Dealer d){

        Dealer dl = context.Dealer.Find(d);
        if(dl==null){
            return NotFound();
        }
        // context.Dealer.Remove(d);
        // context.SaveChanges();
        return RedirectToAction("Index");
      
    }

}

