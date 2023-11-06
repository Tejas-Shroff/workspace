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
        Department department = context.Departments.Find(id);
        context.Departments.Remove(department);
        context.SaveChanges();
    

    }
    public void EditDept(Department dept){
        Department department = context.Departments.Find(dept.Id);
        Department.DeptName = dept.DeptName;
        Department.Location = dept.Location;
        context.SaveChanges();

    }
    public Department FindDept(int id){
        var data = context.Departments.Find(id);
        return data;

    }
    public List<Department> GetDepartments(){

        return.context.Departments.ToList();

    }
}