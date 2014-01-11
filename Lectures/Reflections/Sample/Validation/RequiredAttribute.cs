namespace Sample.Validation
{
    public class RequiredAttribute : PropertyValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var s = value as string;

            return s != null && !string.IsNullOrWhiteSpace(s);
        }
    }
}