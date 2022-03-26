using TextHandlingWithAttributes.Handling.Attributes;

namespace TextHandlingWithAttributes.Handling.Handlers
{
    [Handling]
    public class UpperCaseHandler : Handler<UpperCaseAttribute>
    {
        public override object Handle(object value)
        {
            return value.ToString()
                        .ToUpper();
        }
    }
}