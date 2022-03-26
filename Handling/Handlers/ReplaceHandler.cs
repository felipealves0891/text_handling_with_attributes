using TextHandlingWithAttributes.Handling.Attributes;
using System.Globalization;

namespace TextHandlingWithAttributes.Handling.Handlers
{
    [Handling]
    public class ReplaceHandler : Handler<ReplaceAttribute>
    {
        public override object Handle(object value)
        {
            return value.ToString()
                        .Replace(Attribute.Old, Attribute.New, true, new CultureInfo("pt_BR"));
        }
    }
}