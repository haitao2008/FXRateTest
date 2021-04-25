using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;



namespace FXRate.Infrastructure
{
    public class FXContext : DbContext
    {
        public DbSet<FXRateItem> FXRateItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GEN2-L-4SC2P73;Database=FXTest;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

       
    }
}
