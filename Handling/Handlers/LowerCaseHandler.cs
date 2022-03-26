using System;
using TextHandlingWithAttributes.Handling.Attributes;

namespace TextHandlingWithAttributes.Handling.Handlers
{
    [Handling]
    public class LowerCaseHandler : Handler<LowerCaseAttribute>
    {
        public override object Handle(object value)
        {
            return value.ToString()
                        .ToLower();
        }
    }
}