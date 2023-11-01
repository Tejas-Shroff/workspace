using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCProject.Models;
namespace MVCProject.Controllers;

public class StudentController:Controller{
    public IActionResult List(){

        SqlConnection C = new SqlConnection(@"User ID = sa;password =examlyMssql@123;
        server =localhost;Database=TejDb;trusted_connection =false;Persist Security Info=False;Encrypt =False ");
        SqlCommand command = new SqlCommand("Select * from Student" , C);  
        C.Open();
        SqlDataReader R = command.ExecuteReader();
        DataTable DT = new DataTable();
        DT.Load(R);
        return View(DT);

    }
    public IActionResult AddRecord(int id, string name , int hindi , int maths, int english){
        SqlConnection C = new SqlConnection(@"User ID = sa;password =examlyMssql@123;
        server =localhost;Database=TejDb;trusted_connection =false;Persist Security Info=False;Encrypt =False ");
        SqlCommand command = new SqlCommand("AddRecord" , C);  
        command.CommandType=CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id",id);
        
        command.Parameters.AddWithValue("@name",name);
        
        command.Parameters.AddWithValue("@hindi",hindi);
        
        command.Parameters.AddWithValue("@maths",maths);
        
        command.Parameters.AddWithValue("@english",english);


        C.Open();
        SqlDataReader R = command.ExecuteReader();
        DataTable DT = new DataTable();
        DT.Load(R);
        return View(DT);

    }
}