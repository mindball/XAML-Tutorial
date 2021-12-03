
using ChessBazar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.ViewModels
{
    public class GrandMasterAddViewModel : BaseNotifyPropertyChanged
    {
        private string name;
        private decimal price;
        private int craziness;
               
        public string Name
        {
            get => this.name; 
            set 
            {
                this.name = value;
                this.OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get => this.price;
            set
            {
                this.price = value;
                this.OnPropertyChanged();
            }
        }

        public int Craziness
        {
            get => this.craziness;
            set
            {
                this.craziness = value;
                this.OnPropertyChanged();
            }
        }

        //Good practice is to DI dbcontext-a or service
        //but for this demo make this way
        public void Add()
        {
            using (var dbContext = new ChessDBContext())
            {
                var newGM = new GrandMaster();
                newGM.Name = this.Name; 
                newGM.Price = this.Price;
                newGM.Craziness = this.Craziness;

                dbContext.GrandMasters.Add(newGM);  
                dbContext.SaveChanges();
            }
            
        }
    }
}
