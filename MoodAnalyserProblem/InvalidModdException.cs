using System;
using System.Runtime.Serialization;

namespace MoodAnalyserProblem
{
    [Serializable]
    internal class InvalidModdException : Exception
    {
        public InvalidModdException()
        {
        }

        public InvalidModdException(string message) : base(message)
        {
        }

        public InvalidModdException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidModdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}