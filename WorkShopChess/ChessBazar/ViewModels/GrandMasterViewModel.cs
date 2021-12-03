using ChessBazar.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.ViewModels
{
    public class GrandMasterViewModel
    {
        public GrandMasterViewModel()
        {
            using(var dbContext = new ChessDBContext())
            {
                this.GMs = new ObservableCollection<GrandMaster>(dbContext.GrandMasters.ToList());
            }
        }

        public ObservableCollection<GrandMaster> GMs { get; set; }
    }
}
