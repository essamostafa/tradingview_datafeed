using System;
using System.Collections.Generic;

namespace PioDataFeed.Models
{
    public partial class Symbolsummary
    {
        public string SymbolCode { get; set; }
        public decimal? SymbolType { get; set; }
        public decimal? CumNumTransact { get; set; }
        public decimal? CumTradeValue { get; set; }
        public decimal? CumVolume { get; set; }
        public decimal? LastTradePrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosePrice { get; set; }
        public decimal? RefPrice { get; set; }
    }
}
