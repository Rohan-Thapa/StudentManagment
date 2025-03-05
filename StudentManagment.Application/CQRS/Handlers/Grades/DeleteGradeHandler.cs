using MediatR;
using StudentManagment.Application.CQRS.Commands;
using StudentManagment.Domain.Enitites;
using StudentManagment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.CQRS.Handlers.Grades
{
    public class DeleteGradeHandler : IRequestHandler<DeleteGradeCommand, Unit>
    {
        private readonly IRepository<Grade> _repository;

        public DeleteGradeHandler(IRepository<Grade> repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteGradeCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.GradeID);
            return Unit.Value;
        }
    }
}
