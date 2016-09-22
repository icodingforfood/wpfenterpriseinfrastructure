using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseInfrastructure.UI
{
    public interface IRegionCollection
    {
        IRegion this[string key] { get; }
    }
}
