namespace EMS.Controllers;

using EMS.Exceptions;
using EMS.Models;
using Microsoft.AspNetCore.Mvc;

public class DeptController:Controller{

    private readonly EmsDbContext context;
        public DeptController(EmsDbContext _context){

        context = _context;

    }

    public IActionResult List(){

        // List<Department>? data =null;
        // try{
        //     data=context.Departments.ToList();
        //     if(data.Count == 0)
        //     throw new Exception();
        // }catch(System.Exception){

        //     ViewBag.ErrorMessage="0 records present";
        //     return View("Error");
        // }
        // return View(data);

        var data = context.Departments.ToList();
        if(data.Count()==0){
            throw new CustomException("O record found");
        }
        return View();
        

        
        

        // var data =context.Departments.ToList();

        // return View(data);

    }
    public IActionResult Create(){
        return View();
    }
    [HttpPost]
    public IActionResult Create(Department department){

        if(ModelState.IsValid){
            
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("List");

        }
        return View();


    }
    public IActionResult Display(int Id){
        var data = context.Employees.Where(e=>e.DeptId==Id);
        return View(data);
    }

}
