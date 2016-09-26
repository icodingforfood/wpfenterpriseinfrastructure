using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace EnterpriseInfrastructure.UI
{
    public interface IRegionManager
    {
        IRegionCollection Regions { get; }
        IRegion RegisterRegion(FrameworkElement regionHost, string regionName);
    }
}
