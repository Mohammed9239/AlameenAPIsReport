using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ameen.ViewModels
{
    public class EnDetails
    {
        public Guid ID { get; set; }

        public string CustomerName { get; set; }
        public string AccountName { get; set; }
        public string CurrencyName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string snd { get; set; }
        public string snd1 { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? Balance { get; set; }
        public string Note { get; set; }
        public double? DebitTotal { get; set; }
        public double? CreditTotal { get; set; }

        public Guid hasbi { get; set; }

        public List<BiDetalis> BiDetalis { get; set; }


    }
}
