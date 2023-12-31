﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EMS.Models;

public partial class Department
{
    public int Id { get; set; }

    [Display(Name = "Department Name")]
    [Required(ErrorMessage = " Department name cannot be blank")]
    public string DeptName { get; set; } = null!;

    [Display(Name = "City")]
    
    [StringLength(25,MinimumLength =3,ErrorMessage ="City Must be 3 Chars")]
    public string? Location { get; set; }

    public ICollection<Employee> Employees { get; set; } 
}
