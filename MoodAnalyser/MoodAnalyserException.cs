using System.Runtime.Serialization;

namespace MoodAnalyserSpace
{
    [Serializable]
    internal class MoodAnalyserException : Exception
    {
        private object nULL_MOOD;
        private string v;

        public MoodAnalyserException()
        {
        }

        public MoodAnalyserException(string? message) : base(message)
        {
        }

        public MoodAnalyserException(object nULL_MOOD, string v)
        {
            this.nULL_MOOD = nULL_MOOD;
            this.v = v;
        }

        public MoodAnalyserException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}