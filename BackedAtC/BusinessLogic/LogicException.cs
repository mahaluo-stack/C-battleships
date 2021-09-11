using System;

namespace BusinessLogic
{
    public class LogicException : Exception
    {
        /// <summary>
        /// Exception constructor with no parameters
        /// </summary>
        public LogicException() { }

        /// <summary>
        /// Exception constructor with string parameter
        /// </summary>
        /// <param name="message">string parameter, use to customize exception</param>
        public LogicException(string message) : base(message) { }

        /// <summary>
        /// Exception constructor with string and exception parameters
        /// </summary>
        /// <param name="message">string parameter, use to customize exception</param>
        /// <param name="inner">exception parameter, use to track exception root</param>
        public LogicException(string message, Exception inner) : base(message, inner) { }
    }
}
