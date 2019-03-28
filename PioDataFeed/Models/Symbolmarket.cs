using System;
using System.Collections.Generic;

namespace PioDataFeed.Models
{
    public partial class Symbolmarket
    {
        public string SymbolCode { get; set; }
        public string MarketCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PrimaryMarket { get; set; }
        public string SymbolStatus { get; set; }
    }
}
