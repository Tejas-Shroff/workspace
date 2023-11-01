using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace Libmvc_CodeFirst.Models;

[Table("Books")]
public class Book {

    public int Id {get;set;}
    
    [MaxLength(100)]
    [Required(ErrorMessage ="Title is required")]
    public string Title {get;set;}
    
    [MaxLength(50)]
    [Required(ErrorMessage ="Author is required")]
    public string Author {get;set;}
    
    public int PublishedYear {get;set;}

    public ICollection<LibraryCard> LibraryCards {get;set;}

}