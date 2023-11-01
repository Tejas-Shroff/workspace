
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
namespace Libmvc_CodeFirst.Models;

[Table("Lib")]
public class LibraryCard{

    [ForeignKey("Book")]
    public int LibId {get;set;}
    
    
    public string CardNumber {get;set;}
    
    [MaxLength(100)]
    [Required(ErrorMessage ="MemberName is required")]
    public string MemberName {get;set;}
    
    public DateTime ExpiryDate {get;set;}

    public Book Book {get;set;} 
    
    

}