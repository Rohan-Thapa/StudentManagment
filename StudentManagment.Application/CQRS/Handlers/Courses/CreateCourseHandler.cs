using AutoMapper;
using MediatR;
using StudentManagment.Application.CQRS.Commands;
using StudentManagment.Application.DTOs;
using StudentManagment.Domain.Enitites;
using StudentManagment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.CQRS.Handlers.Courses
{
    public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, CourseDTO>
    {
        private readonly IRepository<Course> _repository;
        private readonly IMapper _mapper;

        public CreateCourseHandler(IRepository<Course> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CourseDTO> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {
                CourseName = request.CourseName,
                CourseCode = request.CourseCode,
                CreditHours = request.CreditHours
            };

            await _repository.AddAsync(course);
            return _mapper.Map<CourseDTO>(course);
        }
    }
}
