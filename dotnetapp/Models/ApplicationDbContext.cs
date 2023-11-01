using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
// using Microsoft.AspNetCore.Metadata;
using System;
namespace dotnetapp.Models;

public class ApplicationDbContext : DbContext{
    public ApplicationDbContext(){

    }
    public virtual DbSet<Dealer>?Dealer {get ;set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
        if(!optionBuilder.IsConfigured){
            optionBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=ApplicationDb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
        }
    }
}