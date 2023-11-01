using System.ComponentModel.DataAnnotations;
namespace EntityFrameworkPractice.Models;

public class Product{
    
    [Display(Name ="Product Id")]
    [Key]
    [Required(ErrorMessage = "Id is required")]


    public int id {get ;set;}

    [Required(ErrorMessage ="Name cannot be Empty")]
    public string Name {get ; set;}
    public int Price {get ; set;}



    [Range(5,1000 ,ErrorMessage ="Enter the value in range 5 to 1000")]
    public int Stock {get ;set;}


}