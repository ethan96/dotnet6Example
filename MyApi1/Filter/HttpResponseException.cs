using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi1.Exceptions
{
    public class HttpResponseException : Exception
    {
        public HttpResponseException(int statusCode, object? value = null) => (StatusCode, Value) = (statusCode, value);

        public int StatusCode {get;}

        public object? Value {get;}
    }
}