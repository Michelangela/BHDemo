using Microsoft.EntityFrameworkCore;
using StockMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMicroservice.Data
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().HasData(new Stock
            {
                Id = 1,
                Symbol = "AMZN",
                Date = new DateTime(2019, 04, 23),
                Price = 1923.77M

            }, new Stock
            {
                Id = 2,
                Symbol = "AMZN",
                Date = new DateTime(2019, 04, 24),
                Price = 1902.00M
            });
        }
    }
}
