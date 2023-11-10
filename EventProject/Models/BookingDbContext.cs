using Microsoft.EntityFrameworkCore;
using Microsoft.EnitityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace EventProject.Models{
    public class BookingDbContext : DbContext{
        public BookingDbContext(){

        }
        public virtual DbSet<Booking> Bookings {get;set;}
        
        public virtual DbSet<EventSpace> EventSpaces {get;set;}
        public BookingDbContext(DbContextOptions<BookingDbContext>options) : base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                UseSqlServer.optionsBuilder("User ID=sa;password=examlyMssql@123; server=localhost;Database=BookingDb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
            }
        }
    }
}