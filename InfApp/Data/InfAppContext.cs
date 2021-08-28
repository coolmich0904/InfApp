using InfApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfApp.Data
{
    public class InfAppContex : DbContext
    {
        public InfAppContex(DbContextOptions options):base(options){}

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
