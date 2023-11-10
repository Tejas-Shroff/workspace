namespace EventProject.Models;
using System.ComponentModel.DataAnnotations;

public class EventSpace{
    public int Id {get;set;}

    public string? Event {get;set;}

    public string? Venue {get;set;}

    public ICollection<Booking>? Bookings {get;set;}

}