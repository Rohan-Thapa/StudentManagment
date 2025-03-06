using AutoMapper;
using MediatR;
using StudentManagment.Application.CQRS.Queries;
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
    public class GetCourseByIdHandler : IRequestHandler<GetCourseByIdQuery, CourseDTO>
    {
        private readonly IRepository<Course> _repository;
        private readonly IMapper _mapper;

        public GetCourseByIdHandler(IRepository<Course> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CourseDTO> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
        {
            var course = await _repository.GetByIdAsync(request.CourseID);
            if (course == null)
            {
                throw new KeyNotFoundException("Course Not Found!");
            }
            return _mapper.Map<CourseDTO>(course);
        }
    }
}
// HandCrafted By Rohan Thapa