using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ameen.ViewModels
{
    public class BiDetalis
    {
        public Guid? MtId { get; set; }
        public string Note { get; set; }
        public double? Unit { get; set; }
        public double? Price { get; set; }

        public double? QunV { get; set; }
        public string UnitV { get; set; }

    }
}
