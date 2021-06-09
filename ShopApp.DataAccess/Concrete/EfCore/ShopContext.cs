using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class ShopContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NIRVANA;Database=ShopApp;Integrated Security=true");
        }

        public DbSet<Product> Products { get; set; } //Pluraize Her classın adı sonuna  s takısı ekler 
        public DbSet<Category> Categories { get; set; }
    }
}
