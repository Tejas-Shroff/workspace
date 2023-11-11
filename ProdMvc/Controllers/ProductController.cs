using Microsoft.AspNetCore.Mvc;
using ProdMvc.Models;

namespace ProdMvc.Controllers;
    public class ProductController : Controller{
        private readonly TejDbContext context;
        public ProductController(TejDbContext  _context){
           context = _context;
        }
        public IActionResult List(){

            var data = context.Product.ToList();
            return View(data);
            
        }
        public IActionResult Display(int id){

            var data = context.Product.Find(id);
            return View(data);

        }

        // Add Record
        public IActionResult create(){

            return View();
            
        }
        [HttpPost]
        public IActionResult create(Product prod){
            if(ModelState.IsValid){
                context.Product.Add(prod);
                context.SaveChanges();
                
                return RedirectToAction("List");
            }
            return View();
        }

        //Edit the Record

        public IActionResult Edit(int id){

            var data = context.Product.Find(id);
            return View(data);

        }
        [HttpPost]
        public IActionResult Edit(Product prod){

            if(ModelState.IsValid){
                Product product = context.Product.Find(prod.Id);
                product.Name=prod.Name;
                product.Price=prod.Price;
                product.Stock=prod.Stock;
                context.SaveChanges();
                return RedirectToAction("List");
            }
            return View();
  

        }

        public IActionResult Delete(int Id){

            var data = context.Product.Find(Id);
            return View(data);

        }
        [HttpPost]

        public IActionResult Delete(Product prod){

            Product product = context.Product.Find(prod.Id);
            context.Product.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List");

        }
    }

   





public IActionResult Edit(int id){
    var data = context.Product.Find(id);
    return View(d);

}
[HttpPost]
public IActionResult Edit(Product P){
    if(ModelState.IsValid){
        Product pr = context.Product.Find(P.id);
        pr.Name=P.Name;
        pr.Price=P.Price;
        pr.Stock=P.Stock;
        context.SaveChanges();
        return RedirectToAction("List");
    }
    return View();
}
public IActionResult Delete(int id){


    var d = context.Product.Find(id);
    return View(d);

}
[HttpPost]
public IActionResult Delete(Product p){

    Product P = context.Product.Find(p.id);
    context.Product.Remove(P);
    context.SaveChanges();
    return RedirectToAction('List');

   
}

public IActionResult Display(int id){
    var data = context.Product.Where(m => m.EmployeeId == id);
    return View(data);
}

public IActionResult Create(){
    return View();
}
[HttpPost]
public IActionResult Create(Product P){
    
}
