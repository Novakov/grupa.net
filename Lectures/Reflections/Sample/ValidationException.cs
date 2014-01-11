using System;

namespace Sample
{
    public class ValidationException : Exception
    {
        public string[] InvalidProperties { get; private set; }

        public ValidationException(string[] invalidProperties)
        {
            this.InvalidProperties = invalidProperties;
        }
    }
}