using System;

namespace TextHandlingWithAttributes.Handling.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UpperCaseAttribute : Attribute
    {
        public string Version { get; private set; } 

        public UpperCaseAttribute()
        {
            Version = "1.0";    
        }
    }
}