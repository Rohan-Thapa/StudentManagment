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

namespace StudentManagment.Application.CQRS.Handlers.Grades
{
    public class CreateGradeHandler : IRequestHandler<CreateGradeCommand, GradeDTO>
    {
        private readonly IRepository<Grade> _repository;
        private readonly IMapper _mapper;

        public CreateGradeHandler(IRepository<Grade> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GradeDTO> Handle(CreateGradeCommand request, CancellationToken cancellationToken)
        {
            var grade = new Grade
            {
                StudentID = request.StudentID,
                CourseID = request.CourseID,
                LetterGrade = request.LetterGrade
            };
            await _repository.AddAsync(grade);
            return _mapper.Map<GradeDTO>(grade);
        }
    }
}
