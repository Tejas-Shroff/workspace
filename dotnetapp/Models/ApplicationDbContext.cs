using System.ComponentModel.DataAnnotations;
using System;
namespace dotnetapp.Models;

public class ApplicationDbContext : Dbcontext{
    public ApplicationDbContext(){

    }
    public virtual DbSet<Dealer>Dealer {get ;set;}
    public ApplicationDbContext(DbcontextOptions<ApplicationDbContext>options):base(options){

    }

    public override void OnConfiguring(DbContextOptionBuilder optionBuilder{
        if(!optionBuilder.IsConfigured){
            optionBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=ApplicationDb;trusted_connection=false;Persist Security Info=False;Encrypt=False")
        }
    })
}