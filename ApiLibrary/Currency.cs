using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    public class Currency
    {
        public string  Base { get; set; }
        public DateTime Date { get; set; }

        public  CurrencyRates Rates { get; set; }
    }
}
