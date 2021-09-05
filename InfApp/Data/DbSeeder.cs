using InfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfApp.Data
{
    public class DbSeeder
    {
        private InfAppContex _context;
        public DbSeeder(InfAppContex context)
        {
            _context = context;
        }

        public async Task SeedDatabase()
        {
            if(!_context.Teachers.Any())
            {
                List<Teacher> teachers = new List<Teacher>()
                {
                    new Teacher() {Name="James", Class="C# Programming"},
                    new Teacher() { Name="Eliana", Class="Data Structure" },
                    new Teacher() { Name="Edgar", Class="Modern Javascript"},
                    new Teacher() { Name="Shan", Class="Project Management"}
                };

                await _context.AddRangeAsync(teachers);
                //await _context.AddAsync(new Teacher() { Name = "James", Class = "C# Programming" });
                await _context.SaveChangesAsync();
            }
        }

    }
}
