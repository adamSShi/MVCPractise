using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCTest.Models;

namespace MVCTest.Data
{
    public class MVCStudentContext : DbContext
    {
        public MVCStudentContext (DbContextOptions<MVCStudentContext> options)
            : base(options)
        {
        }

        public DbSet<MVCTest.Models.Student> Student { get; set; } = default!;
    }
}
