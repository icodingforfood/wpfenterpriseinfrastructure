using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseInfrastructure.UI
{
    public interface IViewLocator
    {
        object Locate(object view);
        object Locate(IViewModel viewModel);
    }
}
