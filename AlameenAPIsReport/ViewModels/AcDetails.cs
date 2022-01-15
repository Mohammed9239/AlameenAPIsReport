using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ameen.ViewModels
{
    public class AcDetails
    {
        public Guid ID { get; set; }
        public string AcName { get; set; }
        public string Currency { get; set; }
        public string AcParent { get; set; }
        public string AcFinally { get; set; }
        public double? Credit { get; set; }
        public double? Debit { get; set; }
        public double?  Balance { get; set; }
        public string BalanceText { get; set; }

    }
}
