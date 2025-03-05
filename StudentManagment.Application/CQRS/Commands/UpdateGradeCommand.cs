using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.CQRS.Commands
{
    public class UpdateGradeCommand : IRequest<Unit>
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string? GradeLetter { get; set; }
        public UpdateGradeCommand(int gradeID, int studentID, int courseID, string? gradeLetter)
        {
            GradeID = gradeID;
            StudentID = studentID;
            CourseID = courseID;
            GradeLetter = gradeLetter;
        }
    }
}
