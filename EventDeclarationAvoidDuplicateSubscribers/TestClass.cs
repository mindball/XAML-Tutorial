using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDeclarationAvoidDuplicateSubscribers
{
    public class TestClass : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler _PropertyChanged;
        private List<PropertyChangedEventHandler> subscribers =
            new List<PropertyChangedEventHandler>();

        public event PropertyChangedEventHandler PpropertyChanged
        {
            add
            {
                if (!subscribers.Contains(value))
                {
                    _PropertyChanged += value;
                    subscribers.Add(value); 

                }
            }
            remove
            {
                _PropertyChanged -= value;
                subscribers.Remove(value);  
            }
        }


    }
}
