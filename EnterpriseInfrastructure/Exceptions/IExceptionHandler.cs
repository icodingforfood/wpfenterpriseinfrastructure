using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseInfrastructure.Exceptions
{
    public interface IExceptionHandler
    {
        bool HandleException(object sender, System.Exception exception);
    }
}
