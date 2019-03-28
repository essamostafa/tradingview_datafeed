using System;
using System.Collections.Generic;

namespace PioDataFeed.Models
{
    public partial class Tradescancel
    {
        public DateTime? TradeDate { get; set; }
        public string SymbolCode { get; set; }
        public string MarketCode { get; set; }
        public string TicketNumber { get; set; }
        public decimal? TradePrice { get; set; }
        public decimal? VolumeTraded { get; set; }
        public decimal? TradeValue { get; set; }
        public decimal? LeValue { get; set; }
        public DateTime? ExecTime { get; set; }
        public string BuyOrderNumber { get; set; }
        public string SellOrderNumber { get; set; }
        public decimal? RecCount { get; set; }
        public decimal? RecSerial { get; set; }
    }
}
