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
        context=_context;
    }

    public IActionResult List(){
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
            return RedirectToAction("List");

        }
        return View();
    }
    public IActionResult Delete(int ID){
        var data = context.Dealer.Find(id);
        return View(data);
    }
    [HttpPost]
    public IActionResult Delete(Dealer d){

        Dealer dl = context.Dealer.Find(d.ID);
        context.Dealer.Remove(d);
        context.Dealer.SaveChanges();
        return RedirectToAction()
      
    }

}

