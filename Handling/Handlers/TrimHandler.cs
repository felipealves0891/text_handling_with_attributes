using TextHandlingWithAttributes.Handling.Attributes;

namespace TextHandlingWithAttributes.Handling.Handlers
{
    [Handling]
    public class TrimHandler : Handler<TrimAttribute>
    {
        public override object Handle(object value)
        {
            return value.ToString()
                        .Trim();
        }
    }
}