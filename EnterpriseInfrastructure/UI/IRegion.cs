using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseInfrastructure.UI
{
    public interface IRegion
    {
        event EventHandler ViewCollectionChanged;
        string ZoneName { get; set; }
        IEnumerable<object> Views { get; }
        void Add(object view);
        void Add(string viewName, object view);
        bool Contains(object view);
        bool Contains(string viewName);
        object GetView(string viewName);
        void Remove(object view);
        void Remove(string viewName);
    }
}
