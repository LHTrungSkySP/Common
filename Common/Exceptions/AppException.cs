using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class AppException: Exception
    {
        public ExceptionCode Code { get; }

        public IEnumerable<string> Errors { get; }
        public IEnumerable<ErrorDetail> ErrorDetails { get; }

        public AppException() { }
        public AppException(string message) : base(message) { }
        public AppException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {

        }
        public AppException(ExceptionCode code, string message, IEnumerable<ErrorDetail>? errorDetails = null) : base("")
        {
            Code = code;
            Errors = new List<string>() { message };
            ErrorDetails = errorDetails ?? new List<ErrorDetail>();
        }


    }
    public enum ExceptionCode
    {
        Invalidate = 1,
        Notfound = 2,
        Duplicate = 3,
    }
    public class ErrorDetail
    {
        public string Key { get; }
        public dynamic Value { get; }

        public ErrorDetail(string key, dynamic value)
        {
            Key = key;
            Value = value;
        }
    }

}
