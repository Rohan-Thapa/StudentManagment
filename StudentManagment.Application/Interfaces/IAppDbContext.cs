using Microsoft.EntityFrameworkCore;
using StudentManagment.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Student> Students { get; }
        DbSet<Course> Courses { get; }
        DbSet<Enrollment> Enrollments { get; }
        DbSet<Grade> Grades { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
