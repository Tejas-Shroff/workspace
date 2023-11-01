using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;

public class Dealer{
    public int ID {get;set;}
    public string? Name {get;set;}
    
    public DateOnly RegistrationDate {get;set;}

    public string? AutoPartName {get;set;}
    public string? Manufacturer {get;set;}
    public int MobileNumber {get;set;}
    public string? Email {get;set;}
    public string? Description {get;set;}
    
}