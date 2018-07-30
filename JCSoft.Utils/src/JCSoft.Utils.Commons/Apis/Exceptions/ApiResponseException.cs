using System;

namespace JCSoft.Utils.Commons.Apis.Exceptions
{
    public class ApiResponseException : Exception
    {
        public ApiResponseException() : this(-9999, "未知错误") { }

        public ApiResponseException(int code, string message) : this(code, message, null)
        {

        }

        public ApiResponseException(int code, string message, string reason) : base(message)
        {
            Code = code;
            Reason = reason ?? this.ToString();
        }

        public int Code { get; set; }
        public string Reason { get; set; }
    }
}