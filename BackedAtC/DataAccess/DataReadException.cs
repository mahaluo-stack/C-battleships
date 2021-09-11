using System;

namespace DataAccess
{
    public class DataReadException : Exception
    {
        /// <summary>
        /// Exception constructor with no parameters
        /// </summary>
        public DataReadException() { }

        /// <summary>
        /// Exception constructor with string parameter
        /// </summary>
        /// <param name="message">string parameter, use to customize exception</param>
        public DataReadException(string message) : base(message) { }

        /// <summary>
        /// Exception constructor with string and exception parameters
        /// </summary>
        /// <param name="message">string parameter, use to customize exception</param>
        /// <param name="inner">exception parameter, use to track exception root</param>
        public DataReadException(string message, Exception inner) : base(message, inner) { }
    }
}
