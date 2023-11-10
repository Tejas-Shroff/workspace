using EventProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventProject.Controllers{
    public class BookingController : Controller {
        private readonly BookingDbContext context;
        public BookingController(BookingDbContext _context){
            context=_context;
        }
      
    }
}