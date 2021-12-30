using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vestel_Demo_Api.DAL.Entities;

namespace Vestel_Demo_Api.DAL.Context
{
    public class WebApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-07T8MF2\\MSSQLSERVER01;database=CoreVestelDbApi;integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}