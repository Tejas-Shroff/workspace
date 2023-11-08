namespace EventProject.Models;
using System.ComponentModel.DataAnnotations;

public class Booking{
    public  int ID {get;set;}
    public string? Name {get;set;}
    public DateTime DOB {get;set;}
    public TimeSpan Timeslot {get;set;}
    
}

