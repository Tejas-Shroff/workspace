using System.Linq;
using System.Collections.Generic;
namespace EMSApi.Models;

public class DepartmentRepository : IDept{
    EmsDbContext context = new EmsDbContext();
    public void AdDept(Department dept){
        context.DepartmentRepository.Add(dept);
        context.SaveChanges();

    }
    public void DeleteDept(int id){

    }
    public void EditDept(Department dept){

    }
    public Department FindDept(int id){

    }
    public List<Department> GetDepartments(){
        
    }
}