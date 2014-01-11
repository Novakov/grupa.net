using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class CommandDispatcher
    {
        private static readonly Assembly HandlersAssembly = typeof (CommandDispatcher).Assembly;

        public TResult Execute<TResult>(ICommand<TResult> command)
        {
            var commandHandlerName = string.Format("Sample.CommandHandlers.{0}Handler", command.GetType().Name);

            var commandHandlerType = HandlersAssembly.GetType(commandHandlerName);

            var commandHandlerCtor = commandHandlerType.GetConstructor(Type.EmptyTypes);

            var commandHandler = commandHandlerCtor.Invoke(new object[0]);

            var aspects = commandHandlerType.GetCustomAttributes(true).OfType<HandlerAspectAttribute>();

            foreach (var aspect in aspects)
            {
                aspect.BeforeHandle(command);
            }

            var handleMethod = commandHandlerType.GetMethod("Handle", new Type[] {command.GetType()});

            return (TResult) handleMethod.Invoke(commandHandler, new object[] {command});
        }
    }
}
