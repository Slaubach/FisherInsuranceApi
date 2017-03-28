using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FisherInsuranceApi.Data
{
    public class FisherContext : IdentityDbContext<ApplicationUser>
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       // string connection = "User ID=<YOUR USERNAME HERE>;Password=<YOUR PASSWORD
//HERE > ; Host = localhost; Port = 5432; Database =< YOUR DATABASE NAME HERE >; Pooling = true; ";

            optionsBuilder.UseSQLite(connection);
    }

    public DbSet<Claim> Claims { get; set; }
}
