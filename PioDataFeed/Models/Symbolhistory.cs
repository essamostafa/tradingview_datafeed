using System;
using System.Collections.Generic;

namespace PioDataFeed.Models
{
    public partial class Symbolhistory
    {
        public string SymbolCode { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal? TradeVolume { get; set; }
        public decimal? TradeValue { get; set; }
        public decimal? TradeCount { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosePrice { get; set; }
    }
}
