
using System;
using System.Collections.Generic;
using _3DModels.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace _3DModels.Models
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
        {
        }

        public ModelDbContext(DbContextOptions<ModelDbContext> options)
            : base(options)
        {
        }



        public virtual DbSet<Orders> Orders { get; set; } = null!;
        public virtual DbSet<ModelAccessories> ModelAccessories { get; set; } = null!;
        public virtual DbSet<Users> users { get; set; } = null!;
        public virtual DbSet<Model> model { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}



