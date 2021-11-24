using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Molnar_Lorand_Lab8.Models;

namespace Molnar_Lorand_Lab8.Data
{
    public class Molnar_Lorand_Lab8Context : DbContext
    {
        public Molnar_Lorand_Lab8Context (DbContextOptions<Molnar_Lorand_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Molnar_Lorand_Lab8.Models.Book> Book { get; set; }

        public DbSet<Molnar_Lorand_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Molnar_Lorand_Lab8.Models.Category> Category { get; set; }
    }
}
