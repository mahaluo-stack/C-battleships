using System;

namespace BackedAtC
{
    public class WebServiceException : Exception
    {
        /// <summary>
        /// Exception constructor with no parameters
        /// </summary>
        public WebServiceException() { }

        /// <summary>
        /// Exception constructor with string parameter
        /// </summary>
        /// <param name="message">string parameter, use to customize exception</param>
        public WebServiceException(string message) : base(message) { }

        /// <summary>
        /// Exception constructor with string and exception parameters
        /// </summary>
        /// <param name="message">string parameter, use to customize exception</param>
        /// <param name="inner">exception parameter, use to track exception root</param>
        public WebServiceException(string message, Exception inner) : base(message, inner) { }
    }
}