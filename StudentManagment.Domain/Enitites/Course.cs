using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Domain.Enitites
{
    public class Course
    {
        public int CourseID { get; set; }
        public string? CourseName { get; set; }
        public string? CourseCode { get; set; }
        public int CreditHours { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }
}
// HandCrafted By Rohan Thapa