using System;

namespace ApiResponseShare
{
    public class ApiResponse<T>
    {
        public bool Successfull { get; set; }
        public T Result { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public ApiResponse(T result)
        {
            Successfull = true;
            Result = result;
        }

        public ApiResponse(bool successful)
        {
            Successfull = successful;
        }

        public ApiResponse(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }
    }
}