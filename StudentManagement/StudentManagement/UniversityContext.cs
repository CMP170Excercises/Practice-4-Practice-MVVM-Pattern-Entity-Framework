using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentManagement.StudentDetailViewModel;


namespace StudentManagement
{
    class UniversityContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=StudentManagement_EFCore;MultipleActiveResultSets=true;Trusted_connection=true;Integrated Security=true");
        }
        public DbSet<Student> Students {get; set;} 
}
}
