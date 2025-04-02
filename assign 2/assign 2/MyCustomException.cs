using System;

namespace MyOperations
{
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public MyCustomException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
            ErrorMessage = message;
        }

        public override string ToString()
        {
            return $"Error Code: {ErrorCode}, Message: {ErrorMessage}";
        }
    }
}
