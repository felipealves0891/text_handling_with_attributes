using System;

namespace TextHandlingWithAttributes.Handling
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HandlingAttribute : Attribute
    {
        public string Version { get; private set; }

        public HandlingAttribute()
        {
            Version = "1.0";
        }
        
    }
}