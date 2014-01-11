using System;

namespace Sample.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class PropertyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object value);
    }
}