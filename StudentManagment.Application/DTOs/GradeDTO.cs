using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.DTOs
{
    public class GradeDTO
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string? LetterGrade { get; set; } // A, B, C, D, F
    }
}
