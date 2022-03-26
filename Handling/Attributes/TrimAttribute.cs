using System;

namespace TextHandlingWithAttributes.Handling.Attributes 
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TrimAttribute : Attribute
    {
        public string Version { get; private set; }

        public TrimAttribute()
        {
            Version = "1.0";
        }

    }

}