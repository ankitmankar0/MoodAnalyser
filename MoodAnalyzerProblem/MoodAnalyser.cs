using System;
using System.Collections.Generic;
using System.Text;
using static MoodAnalyzerProblem.MoodAnalyserCustomException;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        string moodMessage;
        public MoodAnalyser(string moodMessage)
        {
            this.moodMessage = moodMessage;
        }

        public MoodAnalyser()
        {
        }

        public string AnalyseMood(string moodMessage)
        {
            try
            {
                if (moodMessage == null)
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NULL_MESSAGE_EXCEPTION, "Null message passed.");
                }
                if (moodMessage.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(ExceptionType.EMPTY_MESSAGE_EXCEPTION, "Empty message passed.");
                }
                if (moodMessage.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}