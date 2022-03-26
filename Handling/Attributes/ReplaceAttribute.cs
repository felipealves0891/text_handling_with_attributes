using System;

namespace TextHandlingWithAttributes.Handling.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ReplaceAttribute : Attribute
    {        
        public string Old { get; private set; }

        public string New { get; private set; }

        public string Version { get; private set; }

        public ReplaceAttribute(string oldString, string newString)
        {
            this.Old = oldString;
            this.New = newString;
            this.Version = "1.0";
        }

    }
}