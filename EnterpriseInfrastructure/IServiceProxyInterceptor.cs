using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace EnterpriseInfrastructure
{
    public interface IServiceProxyInterceptor : IInterceptor, IDependency
    {
    }
}
