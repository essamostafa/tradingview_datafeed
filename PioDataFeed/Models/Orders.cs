using System;
using System.Collections.Generic;

namespace PioDataFeed.Models
{
    public partial class Orders
    {
        public DateTime? OrderDate { get; set; }
        public string SymbolCode { get; set; }
        public string MarketCode { get; set; }
        public string OrderNumber { get; set; }
        public decimal? OrderPrice { get; set; }
        public decimal? VolumeTraded { get; set; }
        public decimal? OriginalVolume { get; set; }
        public decimal? MinimumFillVolume { get; set; }
        public decimal? OrderValue { get; set; }
        public decimal? LeValue { get; set; }
        public DateTime? RegTime { get; set; }
        public DateTime? ExecTime { get; set; }
        public string OrderType { get; set; }
        public string Exchange { get; set; }
        public DateTime? LastTime { get; set; }
        public decimal? MinAmount { get; set; }
        public string OrderAction { get; set; }
        public string TifFlags { get; set; }
        public string FillFlags { get; set; }
        public decimal? RecCount { get; set; }
        public decimal? RecSerial { get; set; }
        public string Family { get; set; }
    }
}
