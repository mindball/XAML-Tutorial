using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls.Models
{
    public class TShirt
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public bool? IsDirty { get; set; }

        public string Size { get; set; }
    }
}
