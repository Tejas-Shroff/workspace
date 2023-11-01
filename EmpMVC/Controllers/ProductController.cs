using Microsoft.AspNetCore.Mvc;
using EmpMVC.Models;
using System.Data;
using System.Data.SqlClient;
namespace EmpMVC.Controllers;
public class ProductController : Controller {

    public IActionResult Display(int id){
        string constr =" User ID = sa;password =examlyMssql@123;server =localhost;Database=TejDb;trusted_connection =false;Persist Security Info=False;Encrypt =False ";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand command = new SqlCommand("FindT",con);
        command.CommandType =CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id", id);
        con.Open();
        SqlDataReader reader = command.ExecuteReader();
        DataTable p = new DataTable();
        p.Load(reader);
        return View(p);
        
    }

    public IActionResult List(){

        string constr =" User ID = sa;password =examlyMssql@123;server =localhost;Database=TejDb;trusted_connection =false;Persist Security Info=False;Encrypt =False ";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand command = new SqlCommand("Select * from Product", con);
        con.Open();
        SqlDataReader reader = command.ExecuteReader();

        DataTable prodtable = new DataTable();
        prodtable.Load(reader);
        return View(prodtable);

    }
    public IActionResult Create(){
        return View();

    }
    [HttpPost]
    public IActionResult Create (int id , string Name , int Price , int Stock){

        if(ModelState.IsValid){
            string constr ="User ID = sa;password =examlyMssql@123;server =localhost;Database=TejDb;trusted_connection =false;Persist Security Info=False;Encrypt =False";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand command = new SqlCommand("AddProduct",con);
            command.CommandType=CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id",id);
        
            command.Parameters.AddWithValue("@Name",Name);
            
            command.Parameters.AddWithValue("@Price",Price);
            
            command.Parameters.AddWithValue("@Stock",Stock);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("List"); 
        }
        
        return View();

    }

}