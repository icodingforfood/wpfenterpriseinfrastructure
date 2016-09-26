using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EnterpriseInfrastructure
{
    public interface IViewModel : INotifyPropertyChanged, IDependency
    {
    }
}
