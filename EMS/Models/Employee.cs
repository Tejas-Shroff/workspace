using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    [Required(ErrorMessage="Name is requried")]
    public string? Name { get; set; } 
    [Range(10000,90000,ErrorMessage="Salary must be betwwen 10000 and 90000")]

    public int Salary { get; set; }

    [Display(Name = "Department")]

    public int DeptId { get; set; }


    [Display(Name =" Email")]
    [DataType(DataType.EmailAddress)]

    public string? Email { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:yyyy-mm-dd}")]
    
    [DobCheck(ErrorMessage="You should be 25 years of age to work in LTI")]

    public DateTime Dob { get; set; }

    public Department Dept { get; set; }
}
