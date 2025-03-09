using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Domain.Errors
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; }
        public string? ErrorMessage { get; }
        public T? Data { get; }

        public ServiceResult(bool isSuccess, string? errorMessage, T? data)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Data = data;
        }

        public static ServiceResult<T> AsSuccess(T data)
        {
            return new ServiceResult<T>(true, null, data);
        }

        public static ServiceResult<T> AsFailure(string errorMessage)
        {
            return new ServiceResult<T>(false, errorMessage, default);
        }
    }
}
