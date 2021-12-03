using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.Data
{
    public class ChessDBContext : DbContext
    {
        public ChessDBContext()
            : base("DefaultConnection")
        {
        }

        public IDbSet<GrandMaster> GrandMasters { get; set; }
    }
}
