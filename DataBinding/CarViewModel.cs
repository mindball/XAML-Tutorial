using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class CarViewModel : INotifyPropertyChanged
    {
        private string manufacture;
        private string model;
        private decimal yearOfDrived;
        private string created;

        public event PropertyChangedEventHandler PropertyChanged;

        public CarViewModel()
        {
            this.Manufacture = "audi";
            this.Model = "S8";
            this.YearsOfDrived = 1232222;
            this.Created = "12***11***2021";
        }

        public string Manufacture
        {
            get
            {
                return this.manufacture;
            }
            set
            {
                this.manufacture = value;
                OnProperyChanged();
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
                OnProperyChanged();
            }

        }

        public decimal YearsOfDrived
        {
            get
            {
                return this.yearOfDrived;
            }
            set
            {
                this.yearOfDrived = value;
                OnProperyChanged();
            }

        }

        public string Created
        {
            get
            {
                return this.created;
            }
            set
            {
                this.created = value;
                 OnProperyChanged();
            }

        }
        public void OnProperyChanged([CallerMemberName] string propName = "")
        {
            if (PropertyChanged != null)
            {
                var propertyChangedEventArgs = new PropertyChangedEventArgs(propName);
                PropertyChanged(this, propertyChangedEventArgs);
            }
        }
    }
}
