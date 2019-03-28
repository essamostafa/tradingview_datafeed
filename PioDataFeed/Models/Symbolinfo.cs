using System;
using System.Collections.Generic;

namespace PioDataFeed.Models
{
    public partial class Symbolinfo
    {
        public string SymbolCode { get; set; }
        public string SymbolType { get; set; }
        public string SectorId { get; set; }
        public string EngName { get; set; }
        public string ArbName { get; set; }
        public string Isin { get; set; }
        public string Reuters { get; set; }
        public string Currency { get; set; }
        public string BondType { get; set; }
        public decimal? ListedShares { get; set; }
        public decimal? PaidShares { get; set; }
        public decimal? FaceValue { get; set; }
        public string CouponValue { get; set; }
        public DateTime? CouponDate { get; set; }
        public decimal? NetProfit { get; set; }
        public DateTime? NetProfitDate { get; set; }
        public decimal? Eps { get; set; }
        public decimal? PeRatio { get; set; }
        public DateTime? LastTradeDate { get; set; }
        public decimal? DividendYieldPerc { get; set; }
        public decimal? MarketCap { get; set; }
        public decimal? OpenPrice { get; set; }
    }
}
