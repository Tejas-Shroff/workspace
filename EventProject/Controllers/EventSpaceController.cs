using EventProject.Models;
namespace EventProject.Controllers{
    public class EventSpaceController : Controller {
        private readonly BookingDbContext context;
        public EventSpaceController(BookingDbContext _context){
            context=_context;
        }
      
    }
}