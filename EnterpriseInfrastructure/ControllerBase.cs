
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseInfrastructure
{
    public class ControllerBase : IController
    {
        private readonly string _registeredRegionName;

        public ControllerBase()
        {

        }

        public ControllerBase(string registeredRegionName)
            : this()
        {
            this._registeredRegionName = registeredRegionName;
        }

        public void Initialize()
        {
        }
    }
}
