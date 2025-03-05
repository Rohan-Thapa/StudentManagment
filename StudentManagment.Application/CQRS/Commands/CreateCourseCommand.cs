using MediatR;
using StudentManagment.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.CQRS.Commands
{
    public record CreateCourseCommand(string CourseName, string CourseCode, int CreditHours) : IRequest<CourseDTO>;
}
