using System;
using System.Reflection;


namespace TextHandlingWithAttributes.Handling.Handlers
{
    public abstract class Handler<T> : IHandler where T : System.Attribute
    {
        protected T Attribute;

        public void Execute(object instance)
        {
            PropertyInfo[] properties 
                        = instance.GetType().GetProperties();

            foreach(PropertyInfo property in properties)
            {
                if(property.IsDefined(typeof(T), false))
                {
                    Attribute = property.GetCustomAttribute<T>();
                    object value = property.GetValue(instance);
                    object treatedValue = Handle(value);
                    property.SetValue(instance, treatedValue); 
                }
            }
        }

        public abstract object Handle(object value);
    }
}