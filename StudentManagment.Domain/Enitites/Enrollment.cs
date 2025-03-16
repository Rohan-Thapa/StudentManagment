using StudentManagment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Domain.Enitites
{
    public class Enrollment : IHasLastUpdated
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public Student? Student { get; set; }
        public int CourseID { get; set; }
        public Course? Course { get; set; }
        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdated { get; set; }
    }
}
// HandCrafted By Rohan Thapa