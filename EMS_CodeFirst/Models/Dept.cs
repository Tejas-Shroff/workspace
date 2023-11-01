using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace EMS_CodeFirst.Models;

[Table("Department")]
public class Dept{
    // [Display(Name="Product Id")]
    // [Key]
    // [Required(ErrorMessage="Id cannot be null")]
    public int Id {get;set;} //By default it is Primary key.

    [Required(ErrorMessage="Name cannot be null")]
    [MaxLength(30)]
    [Column("DeptName")]
    public string ?Name {get;set;}

    [MaxLength(30)]
    public string ?Location{get;set;}

    public ICollection<Employee> ?Employees {get;set;}

}