using MediatR;
using StudentManagment.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.CQRS.Commands
{
    public record CreateGradeCommand(int StudentID, int CourseID, char LetterGrade) : IRequest<GradeDTO>;
}
// HandCrafted By Rohan Thapa