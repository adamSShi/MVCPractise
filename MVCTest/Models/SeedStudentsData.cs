using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCTest.Data;
using System;
using System.Linq;


namespace MVCTest.Models
{
    public class SeedStudentsData
    {
        public static void Initailize(IServiceProvider serviceProvider)
        {
            using(var context = new MVCStudentContext(serviceProvider.GetRequiredService<DbContextOptions<MVCStudentContext>>()))
            {
                if (context.Student.Any())
                {
                    return;
                }

                context.Student.AddRange(
                new Student
                {
                    Name = "Adam",
                    Number = 101,
                    GPA = "5.0"
                },
                new Student
                {
                    Name = "Peter",
                    Number = 102,
                    GPA = "1.5"
                },
                new Student
                {
                    Name = "Sam",
                    Number = 111,
                    GPA = "4.8"
                },
                new Student
                {
                    Name = "Betty",
                    Number = 145,
                    GPA = "3.0"
                },
                new Student
                {
                    Name = "JC",
                    Number = 178,
                    GPA = "4.0"
                });
                context.SaveChanges();
            }
        }
    }
}
