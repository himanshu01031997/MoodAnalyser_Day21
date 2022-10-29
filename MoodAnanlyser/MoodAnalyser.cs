using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnanlyser
{
    public class MoodAnalyser
    {
        public string message;

       
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustumException(MoodAnalyserCustumException.ExceptionType.EMPTY_MESSAGE, "mood should not be empty");
                }
                if (this.message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserCustumException(MoodAnalyserCustumException.ExceptionType.NULL_MESSAGE, "mood should not be empty");
            }

        }
    }
}
