using System;
using System.Collections.Generic;
using System.Linq;
using TextHandlingWithAttributes.Handling.Handlers;

namespace TextHandlingWithAttributes.Handling
{
    public class HandlersFactory
    {
        private readonly IEnumerable<IHandler> _handlers;

        public HandlersFactory(string AssemblyName = null)
        {
            string myAssemblyName = AssemblyName ?? this.GetType().Assembly.GetName().Name;

            _handlers = AppDomain.CurrentDomain
                                .GetAssemblies()
                                .SingleOrDefault(x => x.GetName().Name == myAssemblyName)
                                .GetTypes()
                                .Where(x => x.IsDefined(typeof(HandlingAttribute), false))
                                .Select(x => Activator.CreateInstance(x))
                                .Select(x => x as IHandler)
                                .Where(x => x != null);
        }

        public void Execute(object instance)
        {
            foreach(IHandler handler in _handlers)
                handler.Execute(instance);
        }
    }
}