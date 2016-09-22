using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseInfrastructure.Commands
{
    public class DelegateCommand : DelegateCommandBase
    {
        public DelegateCommand(Action executeMethod)
            : this(executeMethod, () => true)
        {

        }

        public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
            : base((o) => executeMethod(), (o) => canExecuteMethod())
        {
            if (executeMethod == null || canExecuteMethod == null)
            {
                throw new ArgumentNullException("executeMethod", "neither the executeMethod nor the canExecuteMethod delegates can be null.");
            }
        }

        ///<summary>
        /// Executes the command.
        ///</summary>
        public void Execute()
        {
            Execute(null);
        }

        /// <summary>
        /// Determines if the command can be executed.
        /// </summary>
        /// <returns>Returns <see langword="true"/> if the command can execute,otherwise returns <see langword="false"/>.</returns>
        public bool CanExecute()
        {
            return CanExecute(null);
        }
    }

    public class DelegateCommand<T> : DelegateCommandBase
    {
        public DelegateCommand(Action<T> executeMethod)
            : this(executeMethod, (o) => true)
        {

        }

        public DelegateCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
            : base((o) => executeMethod((T)o), (o) => canExecuteMethod((T)o))
        {
            if (executeMethod == null || canExecuteMethod == null)
            {
                throw new ArgumentNullException("executeMethod", "neither the executeMethod nor the canExecuteMethod delegates can be null.");
            }

            Type genericType = typeof(T);
            if (genericType.IsValueType)
            {
                if ((!genericType.IsGenericType) || (!typeof(Nullable<>).IsAssignableFrom(genericType.GetGenericTypeDefinition())))
                {
                    throw new InvalidCastException("T for DelegateCommand<T> is not an object nor Nullable.");
                }
            }
        }
    }
}
