using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Basvuru> Basvurus { get; set; }
        public DbSet<Ilan> Ilans { get; set; }
        public DbSet<Deneyim> Deneyims { get; set; }
        public DbSet<Egitim> Egitims { get; set; }
        public DbSet<Aday> Adays { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
