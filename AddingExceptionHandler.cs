using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_1
{
    [System.Serializable]
    class AddingExceptionHandler : ArgumentOutOfRangeException
    {
        public AddingExceptionHandler()
        {
        }

        public AddingExceptionHandler(string paramName) : base(paramName)
        {
        }

        public AddingExceptionHandler(string paramName, string message) : base(paramName, message)
        {
        }

        public AddingExceptionHandler(string message, Exception innerException) : base(message, innerException)
        {
        }

        public AddingExceptionHandler(string paramName, object actualValue, string message) : base(paramName, actualValue, message)
        {
        }

        protected AddingExceptionHandler(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
