using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Sample.Validation;

namespace Sample.Aspects
{
    public class ValidateCommandAttribute : HandlerAspectAttribute
    {
        public override void BeforeHandle(object command)
        {
            var commandType = command.GetType();

            var invalidProperties = new List<string>();

            foreach (var property in commandType.GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var propertyValue = property.GetValue(command);

                var validationAttributes = property.GetCustomAttributes(true).OfType<PropertyValidationAttribute>();

                foreach (var validationAttribute in validationAttributes)
                {
                    if (!validationAttribute.IsValid(propertyValue))
                    {
                        invalidProperties.Add(property.Name);   
                    }
                }
            }

            if (invalidProperties.Any())
            {
                throw new ValidationException(invalidProperties.Distinct().ToArray());
            }
        }
    }
}
