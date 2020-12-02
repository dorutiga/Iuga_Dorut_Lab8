using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iuga_Dorut_Lab8.Models;

namespace Iuga_Dorut_Lab8.Data
{
    public class Iuga_Dorut_Lab8Context : DbContext
    {
        public Iuga_Dorut_Lab8Context (DbContextOptions<Iuga_Dorut_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Iuga_Dorut_Lab8.Models.Book> Book { get; set; }

        public DbSet<Iuga_Dorut_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Iuga_Dorut_Lab8.Models.Category> Category { get; set; }
    }
}
