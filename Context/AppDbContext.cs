using DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class AppDbContext : DbContext
    {
        private string connectionString = "Data Source=Nghh;Initial Catalog=DE1_XEMAY;Integrated Security=True;Trust Server Certificate=True";
        public DbSet<XeMay> XeMay { get; set; }
        public DbSet<LoaiXM> LoaiXM { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        internal void waite()
        {
            throw new NotImplementedException();
        }
    }
}
