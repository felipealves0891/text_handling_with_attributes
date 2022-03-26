using System;

namespace TextHandlingWithAttributes.Handling.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LowerCaseAttribute : Attribute
    {
        public string Version { get; private set; }
        
        public LowerCaseAttribute()
        {
            Version = "1.0";       
        }

    }
}