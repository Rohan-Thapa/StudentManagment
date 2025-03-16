using StudentManagment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Domain.Enitites
{
    public class Grade
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public char LetterGrade { get; set; } = 'F'; // A, B, C, D, F Default being 'F'
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
// HandCrafted By Rohan Thapa