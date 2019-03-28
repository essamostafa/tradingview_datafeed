using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PioDataFeed.Models
{
    public partial class EGIDContext : DbContext
    {
        public EGIDContext()
        {
        }

        public EGIDContext(DbContextOptions<EGIDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Egx100Symbols> Egx100Symbols { get; set; }
        public virtual DbSet<Egx20CapSymbols> Egx20CapSymbols { get; set; }
        public virtual DbSet<Egx30CapSymbols> Egx30CapSymbols { get; set; }
        public virtual DbSet<Egx50Symbols> Egx50Symbols { get; set; }
        public virtual DbSet<Egx70Symbols> Egx70Symbols { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<SectionsArb> SectionsArb { get; set; }
        public virtual DbSet<Sectors> Sectors { get; set; }
        public virtual DbSet<SptSymbolhistory> SptSymbolhistory { get; set; }
        public virtual DbSet<Symbolhistory> Symbolhistory { get; set; }
        public virtual DbSet<Symbolinfo> Symbolinfo { get; set; }
        public virtual DbSet<Symbolmarket> Symbolmarket { get; set; }
        public virtual DbSet<Symbolsummary> Symbolsummary { get; set; }
        public virtual DbSet<Tradescancel> Tradescancel { get; set; }

        // Unable to generate entity type for table 'dbo.CASEINDEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TRADES'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.16.21.80;Database=EGID;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Egx100Symbols>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("EGX100_SYMBOLS");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Egx20CapSymbols>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("EGX20_CAP_SYMBOLS");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Egx30CapSymbols>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("EGX30_CAP_SYMBOLS");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Egx50Symbols>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("EGX50_SYMBOLS");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Egx70Symbols>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("EGX70_SYMBOLS");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderNumber);

                entity.ToTable("ORDERS");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasMaxLength(25)
                    .ValueGeneratedNever();

                entity.Property(e => e.Exchange)
                    .HasColumnName("EXCHANGE")
                    .HasMaxLength(3);

                entity.Property(e => e.ExecTime)
                    .HasColumnName("EXEC_TIME")
                    .HasColumnType("date");

                entity.Property(e => e.Family)
                    .HasColumnName("FAMILY")
                    .HasMaxLength(4);

                entity.Property(e => e.FillFlags)
                    .HasColumnName("FILL_FLAGS")
                    .HasMaxLength(20);

                entity.Property(e => e.LastTime)
                    .HasColumnName("LAST_TIME")
                    .HasColumnType("date");

                entity.Property(e => e.LeValue)
                    .HasColumnName("LE_VALUE")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .HasMaxLength(5);

                entity.Property(e => e.MinAmount)
                    .HasColumnName("MIN_AMOUNT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.MinimumFillVolume)
                    .HasColumnName("MINIMUM_FILL_VOLUME")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.OrderAction)
                    .HasColumnName("ORDER_ACTION")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("ORDER_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OrderPrice)
                    .HasColumnName("ORDER_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.OrderType)
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(4);

                entity.Property(e => e.OrderValue)
                    .HasColumnName("ORDER_VALUE")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.OriginalVolume)
                    .HasColumnName("ORIGINAL_VOLUME")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.RecCount)
                    .HasColumnName("REC_COUNT")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RecSerial)
                    .HasColumnName("REC_SERIAL")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RegTime)
                    .HasColumnName("REG_TIME")
                    .HasColumnType("date");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12);

                entity.Property(e => e.TifFlags)
                    .HasColumnName("TIF_FLAGS")
                    .HasMaxLength(20);

                entity.Property(e => e.VolumeTraded)
                    .HasColumnName("VOLUME_TRADED")
                    .HasColumnType("numeric(11, 0)");
            });

            modelBuilder.Entity<Sections>(entity =>
            {
                entity.HasKey(e => e.SecId);

                entity.ToTable("SECTIONS");

                entity.Property(e => e.SecId)
                    .HasColumnName("SEC_ID")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Section)
                    .HasColumnName("SECTION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SectionsArb>(entity =>
            {
                entity.HasKey(e => e.SecId);

                entity.ToTable("SECTIONS_ARB");

                entity.Property(e => e.SecId)
                    .HasColumnName("SEC_ID")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Section)
                    .HasColumnName("SECTION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sectors>(entity =>
            {
                entity.HasKey(e => e.SectorCode);

                entity.ToTable("SECTORS");

                entity.Property(e => e.SectorCode)
                    .HasColumnName("SECTOR_CODE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.ArabicDesc)
                    .HasColumnName("ARABIC_DESC")
                    .HasMaxLength(50);

                entity.Property(e => e.EngDesc)
                    .HasColumnName("ENG_DESC")
                    .HasMaxLength(50);

                entity.Property(e => e.SectorApprv)
                    .HasColumnName("SECTOR_APPRV")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<SptSymbolhistory>(entity =>
            {
                entity.HasKey(e => new { e.SymbolCode, e.TradeDate });

                entity.ToTable("SPT_SYMBOLHISTORY");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12);

                entity.Property(e => e.TradeDate).HasColumnName("TRADE_DATE");

                entity.Property(e => e.ClosePrice)
                    .HasColumnName("CLOSE_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.HighPrice)
                    .HasColumnName("HIGH_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.LowPrice)
                    .HasColumnName("LOW_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.OpenPrice)
                    .HasColumnName("OPEN_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.TradeCount)
                    .HasColumnName("TRADE_COUNT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TradeValue)
                    .HasColumnName("TRADE_VALUE")
                    .HasColumnType("numeric(17, 4)");

                entity.Property(e => e.TradeVolume)
                    .HasColumnName("TRADE_VOLUME")
                    .HasColumnType("numeric(11, 0)");
            });

            modelBuilder.Entity<Symbolhistory>(entity =>
            {
                entity.HasKey(e => new { e.SymbolCode, e.TradeDate });

                entity.ToTable("SYMBOLHISTORY");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12);

                entity.Property(e => e.TradeDate)
                    .HasColumnName("TRADE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ClosePrice)
                    .HasColumnName("CLOSE_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.HighPrice)
                    .HasColumnName("HIGH_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.LowPrice)
                    .HasColumnName("LOW_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.OpenPrice)
                    .HasColumnName("OPEN_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.TradeCount)
                    .HasColumnName("TRADE_COUNT")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TradeValue)
                    .HasColumnName("TRADE_VALUE")
                    .HasColumnType("numeric(17, 4)");

                entity.Property(e => e.TradeVolume)
                    .HasColumnName("TRADE_VOLUME")
                    .HasColumnType("numeric(11, 0)");
            });

            modelBuilder.Entity<Symbolinfo>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("SYMBOLINFO");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.ArbName)
                    .HasColumnName("ARB_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.BondType)
                    .HasColumnName("BOND_TYPE")
                    .HasMaxLength(4);

                entity.Property(e => e.CouponDate)
                    .HasColumnName("COUPON_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.CouponValue)
                    .HasColumnName("COUPON_VALUE")
                    .HasMaxLength(25);

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3);

                entity.Property(e => e.DividendYieldPerc)
                    .HasColumnName("DIVIDEND_YIELD_PERC")
                    .HasColumnType("numeric(16, 3)");

                entity.Property(e => e.EngName)
                    .HasColumnName("ENG_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.Eps)
                    .HasColumnName("EPS")
                    .HasColumnType("numeric(16, 3)");

                entity.Property(e => e.FaceValue)
                    .HasColumnName("FACE_VALUE")
                    .HasColumnType("numeric(12, 4)");

                entity.Property(e => e.Isin)
                    .HasColumnName("ISIN")
                    .HasMaxLength(12);

                entity.Property(e => e.LastTradeDate)
                    .HasColumnName("LAST_TRADE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ListedShares)
                    .HasColumnName("LISTED_SHARES")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.MarketCap)
                    .HasColumnName("MARKET_CAP")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.NetProfit)
                    .HasColumnName("NET_PROFIT")
                    .HasColumnType("numeric(17, 4)");

                entity.Property(e => e.NetProfitDate)
                    .HasColumnName("NET_PROFIT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OpenPrice)
                    .HasColumnName("OPEN_PRICE")
                    .HasColumnType("numeric(11, 3)");

                entity.Property(e => e.PaidShares)
                    .HasColumnName("PAID_SHARES")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.PeRatio)
                    .HasColumnName("PE_RATIO")
                    .HasColumnType("numeric(16, 3)");

                entity.Property(e => e.Reuters)
                    .HasColumnName("REUTERS")
                    .HasMaxLength(20);

                entity.Property(e => e.SectorId)
                    .HasColumnName("SECTOR_ID")
                    .HasMaxLength(4);

                entity.Property(e => e.SymbolType)
                    .HasColumnName("SYMBOL_TYPE")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<Symbolmarket>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("SYMBOLMARKET");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .HasMaxLength(4);

                entity.Property(e => e.PrimaryMarket)
                    .HasColumnName("PRIMARY_MARKET")
                    .HasMaxLength(1);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SymbolStatus)
                    .HasColumnName("SYMBOL_STATUS")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Symbolsummary>(entity =>
            {
                entity.HasKey(e => e.SymbolCode);

                entity.ToTable("SYMBOLSUMMARY");

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClosePrice)
                    .HasColumnName("CLOSE_PRICE")
                    .HasColumnType("numeric(11, 3)");

                entity.Property(e => e.CumNumTransact)
                    .HasColumnName("CUM_NUM_TRANSACT")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.CumTradeValue)
                    .HasColumnName("CUM_TRADE_VALUE")
                    .HasColumnType("numeric(14, 3)");

                entity.Property(e => e.CumVolume)
                    .HasColumnName("CUM_VOLUME")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.HighPrice)
                    .HasColumnName("HIGH_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.LastTradePrice)
                    .HasColumnName("LAST_TRADE_PRICE")
                    .HasColumnType("numeric(11, 3)");

                entity.Property(e => e.LowPrice)
                    .HasColumnName("LOW_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.RefPrice)
                    .HasColumnName("REF_PRICE")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SymbolType)
                    .HasColumnName("SYMBOL_TYPE")
                    .HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<Tradescancel>(entity =>
            {
                entity.HasKey(e => e.TicketNumber);

                entity.ToTable("TRADESCANCEL");

                entity.Property(e => e.TicketNumber)
                    .HasColumnName("TICKET_NUMBER")
                    .HasMaxLength(25)
                    .ValueGeneratedNever();

                entity.Property(e => e.BuyOrderNumber)
                    .HasColumnName("BUY_ORDER_NUMBER")
                    .HasMaxLength(25);

                entity.Property(e => e.ExecTime)
                    .HasColumnName("EXEC_TIME")
                    .HasColumnType("date");

                entity.Property(e => e.LeValue)
                    .HasColumnName("LE_VALUE")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .HasMaxLength(4);

                entity.Property(e => e.RecCount)
                    .HasColumnName("REC_COUNT")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.RecSerial)
                    .HasColumnName("REC_SERIAL")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.SellOrderNumber)
                    .HasColumnName("SELL_ORDER_NUMBER")
                    .HasMaxLength(25);

                entity.Property(e => e.SymbolCode)
                    .HasColumnName("SYMBOL_CODE")
                    .HasMaxLength(12);

                entity.Property(e => e.TradeDate)
                    .HasColumnName("TRADE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TradePrice)
                    .HasColumnName("TRADE_PRICE")
                    .HasColumnType("numeric(16, 8)");

                entity.Property(e => e.TradeValue)
                    .HasColumnName("TRADE_VALUE")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.VolumeTraded)
                    .HasColumnName("VOLUME_TRADED")
                    .HasColumnType("numeric(11, 0)");
            });
        }
    }
}
