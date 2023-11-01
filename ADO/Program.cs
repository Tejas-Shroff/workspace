// See https://aka.ms/new-console-template for more information

using System;
using System.Data.SqlClient;

SqlConnection con = new SqlConnection(@"Data source = User ID = sa;password =examlyMssql@123;server =localhost;Database=TejDb;trusted_connection =false;Persist Security Info=False;Encrypt =False ");
SqlCommand command = new SqlCommand("Select * from Product" ,con);



try{

    con.Open();

    SqlDataReader reader = new SqlDataReader()

}catch(Exception ex){
    Console.WriteLine(ex.Message);
}finally{
    con.Close();
}

