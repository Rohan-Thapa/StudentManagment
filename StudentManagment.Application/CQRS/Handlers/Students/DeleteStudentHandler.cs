using MediatR;
using StudentManagment.Application.CQRS.Commands;
using StudentManagment.Domain.Enitites;
using StudentManagment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Application.CQRS.Handlers.Students
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, Unit>
    {
        private readonly IRepository<Student> _repository;

        public DeleteStudentHandler(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.StudentID);
            return Unit.Value; // Return Unit.Value instead of just Task
        }
    }
}
// HandCrafted By Rohan Thapa