using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Domain.Errors
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T? Data { get; set; }

        public static ServiceResult<T> AsSuccess(T data, string message="Operation Successful")
        => new() { IsSuccess = true, Data=data, ErrorMessage = message };

        public static ServiceResult<T> AsFailure(string errorMessage)
        => new() { IsSuccess = false, ErrorMessage = errorMessage };
    }
}
