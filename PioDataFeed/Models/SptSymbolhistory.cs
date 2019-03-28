using System;
using System.Collections.Generic;

namespace PioDataFeed.Models
{
    public partial class SptSymbolhistory
    {
        public string SymbolCode { get; set; }
        public Int32 TradeDate { get; set; }
        public decimal? TradeVolume { get; set; }
        public decimal? TradeValue { get; set; }
        public decimal? TradeCount { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosePrice { get; set; }
    }
}
