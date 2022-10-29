using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnanlyser
{
    public class MoodAnalyserCustumException:Exception
    {
        public enum ExceptionType//enum for exception type//will use while custum exception
        {
            NULL_MESSAGE,EMPTY_MESSAGE,
            NO_SUCH_FIELD,NO_SUCH_METHOD,
            NO_SUCH_CLASS,OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;//type variable
        public MoodAnalyserCustumException(ExceptionType type,string message) : base(message)//(enum:message):message
        {
            this.type = type;
        }


    }
}
