using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ameen.ViewModels
{
    public class MtDetails
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public int? Type { get; set; }
        public string TypeName { get; set; }
        public string Unit { get; set; }
        public string Currency { get; set; }
        public double? Quantity { get; set; }
        public double? Input { get; set; }
        public double? Output { get; set; }
        public double? Balance { get; set; }


    }
}
