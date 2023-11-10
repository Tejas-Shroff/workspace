namespace EventProject.Models;
using System.ComponentModel.DataAnnotations;

public class Booking{
    public  int Id {get;set;}

    public int EventSpaceId {get;set;}
    public string? Name {get;set;}

    [DataType(DataType.Date)]
    public DateTime DOB {get;set;}

    [DataType(DataType.Time)]
    public TimeSpan Timeslot {get;set;}

    public EventSpace? EventSpace {get;set;}
    
}

