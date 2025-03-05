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

namespace StudentManagment.Application.CQRS.Handlers.Enrollments
{
    public class CreateEnrollmentHandler : IRequestHandler<CreateEnrollmentCommand, EnrollmentDTO>
    {
        private readonly IRepository<Enrollment> _repository;
        private readonly IMapper _mapper;

        public CreateEnrollmentHandler(IRepository<Enrollment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<EnrollmentDTO> Handle(CreateEnrollmentCommand request, CancellationToken cancellationToken)
        {
            var enrollment = new Enrollment
            {
                StudentID = request.StudentID,
                CourseID = request.CourseID,
                EnrollmentDate = request.EnrollmentDate
            };

            await _repository.AddAsync(enrollment);
            return _mapper.Map<EnrollmentDTO>(enrollment);
        }
    }
}
