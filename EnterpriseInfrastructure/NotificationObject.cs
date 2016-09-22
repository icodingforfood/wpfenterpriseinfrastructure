using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace EnterpriseInfrastructure
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanged(params string[] propertyNames)
        {
            if (null == propertyNames) throw new ArgumentNullException("propertyNames");
            foreach (var name in propertyNames)
            {
                this.OnPropertyChanged(name);
            }
        }

        protected void OnPropertyChanged<T>(Expression<Func<T>> property)
        {
            PropertyInfo member = (property.Body as MemberExpression).Member as PropertyInfo;
            if (null == member)
            {
                throw new ArgumentException("the lambada expression 'property' should point to a valid property");
            }
            OnPropertyChanged(member.Name);
        }

    }
}
