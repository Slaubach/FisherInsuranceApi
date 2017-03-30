using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FisherInsuranceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FisherInsuranceAPI.Data
{
   public class FisherContext : IdentityDbContext<ApplicationUser>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "User ID=<fisherUser>; Password=<Sammy1> ; Host = localhost; Port = 5432; Database =<fisher-insurance>; Pooling = true; ";            
                optionsBuilder.UseNpgsql(connection);
        }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes { get; set; }

    }
}
