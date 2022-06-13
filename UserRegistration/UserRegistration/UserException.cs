using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserException : Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME, EMPTY_MESSAGE, INVALID_PASSWORD, INVALID_NUMBER
        }
        public ExceptionType Type;
        public UserException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
