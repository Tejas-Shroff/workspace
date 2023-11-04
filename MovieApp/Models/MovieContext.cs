namespace MovieApp.Models;
using Microsoft.EntityFramewrokCore;

public class MovieContext : DbContext{
    public virtual DbSet<Detail> Details { get; set; }
    public virtual DbSet<Movie> Movies { get; set; }
    public MovieContext(){

    }
    public MovieContext(DbContextOptions<MovieContext> options) : base(options){

    }
    protected override void OnConfiguring(DbContextoptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=;EntDb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
        }
    }
}