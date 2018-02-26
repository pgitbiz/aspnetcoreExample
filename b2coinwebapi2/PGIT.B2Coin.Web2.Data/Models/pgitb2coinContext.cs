using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class B2CoinEntites : DbContext
    {
        public virtual DbSet<TblBoard> TblBoard { get; set; }
        public virtual DbSet<TblBoardReply> TblBoardReply { get; set; }
        public virtual DbSet<TblCfgCoin> TblCfgCoin { get; set; }
        public virtual DbSet<TblCfgMarket> TblCfgMarket { get; set; }
        public virtual DbSet<TblCfgUserLevel> TblCfgUserLevel { get; set; }
        public virtual DbSet<TblExchange> TblExchange { get; set; }
        public virtual DbSet<TblLogWallet> TblLogWallet { get; set; }
        public virtual DbSet<TblOrderTrade> TblOrderTrade { get; set; }
        public virtual DbSet<TblOrderTradeArchive> TblOrderTradeArchive { get; set; }
        public virtual DbSet<TblOrderTransfer> TblOrderTransfer { get; set; }
        public virtual DbSet<TblStandardCode> TblStandardCode { get; set; }
        public virtual DbSet<TblTempResult> TblTempResult { get; set; }
        public virtual DbSet<TblTradeAccount> TblTradeAccount { get; set; }
        public virtual DbSet<TblTriggerOrder> TblTriggerOrder { get; set; }
        public virtual DbSet<TblTriggerPrice> TblTriggerPrice { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserAction> TblUserAction { get; set; }
        public virtual DbSet<TblWalletAccount> TblWalletAccount { get; set; }
        public virtual DbSet<TblWalletAccountPool> TblWalletAccountPool { get; set; }
        public virtual DbSet<TblWalletBankInfo> TblWalletBankInfo { get; set; }

        // Unable to generate entity type for table 'dbo.TBL_MARKET_SUMMARY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_CANDLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_ORDER_REFUND'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_ORDER_DEPOSIT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sheet1$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_CANDLE_5MIN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_TRADE_ACCOUNT1111$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_CANDLE_15MIN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_CANDLE_30MIN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_CANDLE_60MIN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_WALLET_ADDRESS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_ORDER_LOAN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_ORDER_WITHDRAW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_CANDLE_DAY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_REFUND'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_LOG_ACCOUNT'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=pgb2coin.database.windows.net;Initial Catalog=pgitb2coin;Integrated Security=False;User ID=pgb2coin;Password=word12!!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        public virtual async Task CommitAsync() => await SaveChangesAsync();

        public virtual void Commit() => SaveChanges();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBoard>(entity =>
            {
                entity.ToTable("TBL_BOARD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("CONTENT");

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("DELETE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDate)
                    .HasColumnName("REG_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("USER_EMAIL")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserHp)
                    .IsRequired()
                    .HasColumnName("USER_HP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBoardReply>(entity =>
            {
                entity.ToTable("TBL_BOARD_REPLY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BoardId).HasColumnName("BOARD_ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("CONTENT")
                    .HasColumnType("text");

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("DELETE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDate)
                    .HasColumnName("REG_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("USER_EMAIL")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCfgCoin>(entity =>
            {
                entity.HasKey(e => e.CoinCode);

                entity.ToTable("TBL_CFG_COIN");

                entity.Property(e => e.CoinCode)
                    .HasColumnName("COIN_CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfirmRepeat).HasColumnName("CONFIRM_REPEAT");

                entity.Property(e => e.ConfirmWithdraw).HasColumnName("CONFIRM_WITHDRAW");

                entity.Property(e => e.Info)
                    .HasColumnName("INFO")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InterestRate)
                    .HasColumnName("INTEREST_RATE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.LoanFee)
                    .HasColumnName("LOAN_FEE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.LoanState).HasColumnName("LOAN_STATE");

                entity.Property(e => e.MaxLoanVolumeSpot)
                    .HasColumnName("MAX_LOAN_VOLUME_SPOT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.MaxWithdrawDay)
                    .HasColumnName("MAX_WITHDRAW_DAY")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.MaxWithdrawOnce)
                    .HasColumnName("MAX_WITHDRAW_ONCE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.MinTradeVolume)
                    .HasColumnName("MIN_TRADE_VOLUME")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.Precision).HasColumnName("PRECISION");

                entity.Property(e => e.PrecisionVolume).HasColumnName("PRECISION_VOLUME");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.WalletIssuedIdx).HasColumnName("WALLET_ISSUED_IDX");

                entity.Property(e => e.WithdrawFeeRate)
                    .HasColumnName("WITHDRAW_FEE_RATE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.WithdrawState).HasColumnName("WITHDRAW_STATE");
            });

            modelBuilder.Entity<TblCfgMarket>(entity =>
            {
                entity.HasKey(e => e.MarketCode);

                entity.ToTable("TBL_CFG_MARKET");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Info)
                    .HasColumnName("INFO")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LiveTradeCount).HasColumnName("LIVE_TRADE_COUNT");

                entity.Property(e => e.MaxQueueCount).HasColumnName("MAX_QUEUE_COUNT");

                entity.Property(e => e.OrderBookCount).HasColumnName("ORDER_BOOK_COUNT");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TradeFeeBuy)
                    .HasColumnName("TRADE_FEE_BUY")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.TradeFeeMaker)
                    .HasColumnName("TRADE_FEE_MAKER")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.TradeFeeSell)
                    .HasColumnName("TRADE_FEE_SELL")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.TradeFeeTaker)
                    .HasColumnName("TRADE_FEE_TAKER")
                    .HasColumnType("decimal(28, 12)");
            });

            modelBuilder.Entity<TblCfgUserLevel>(entity =>
            {
                entity.HasKey(e => e.UserLevel);

                entity.ToTable("TBL_CFG_USER_LEVEL");

                entity.Property(e => e.UserLevel)
                    .HasColumnName("USER_LEVEL")
                    .ValueGeneratedNever();

                entity.Property(e => e.Info)
                    .HasColumnName("INFO")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LoanFeeDiscount)
                    .HasColumnName("LOAN_FEE_DISCOUNT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.OrderCount).HasColumnName("ORDER_COUNT");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TradeFeeDiscount)
                    .HasColumnName("TRADE_FEE_DISCOUNT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.TriggerCount).HasColumnName("TRIGGER_COUNT");

                entity.Property(e => e.WithdrawFeeDiscount)
                    .HasColumnName("WITHDRAW_FEE_DISCOUNT")
                    .HasColumnType("decimal(28, 12)");
            });

            modelBuilder.Entity<TblExchange>(entity =>
            {
                entity.ToTable("TBL_EXCHANGE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BuyOrderId)
                    .IsRequired()
                    .HasColumnName("BUY_ORDER_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BuyOwner)
                    .IsRequired()
                    .HasColumnName("BUY_OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.SellOrderId)
                    .IsRequired()
                    .HasColumnName("SELL_ORDER_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SellOwner)
                    .IsRequired()
                    .HasColumnName("SELL_OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Side).HasColumnName("SIDE");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("decimal(28, 12)");
            });

            modelBuilder.Entity<TblLogWallet>(entity =>
            {
                entity.HasKey(e => e.TxId);

                entity.ToTable("TBL_LOG_WALLET");

                entity.HasIndex(e => new { e.ReceivedTime, e.MarketCoinCode, e.WalletIdx })
                    .HasName("IX_TBL_WALLET_LOG");

                entity.Property(e => e.TxId)
                    .HasColumnName("TX_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.Confirmations).HasColumnName("CONFIRMATIONS");

                entity.Property(e => e.MarketCoinCode).HasColumnName("MARKET_COIN_CODE");

                entity.Property(e => e.ReceivedTime).HasColumnName("RECEIVED_TIME");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.WalletIdx).HasColumnName("WALLET_IDX");
            });

            modelBuilder.Entity<TblOrderTrade>(entity =>
            {
                entity.ToTable("TBL_ORDER_TRADE");

                entity.HasIndex(e => e.CommandCode)
                    .HasName("IDX_ORDER_TRADE_COMMAND_CODE");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("IDX_ORDER_TRADE_CREATE_TIME");

                entity.HasIndex(e => e.TriggerId)
                    .HasName("IDX_ORDER_TRADE_TRIGGER_ID");

                entity.HasIndex(e => new { e.Owner, e.CreateTime })
                    .HasName("IDX_ORDER_TRADE_CREATE_TIME_OWNER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandCode).HasColumnName("COMMAND_CODE");

                entity.Property(e => e.CompletAmount)
                    .HasColumnName("COMPLET_AMOUNT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.CompletVolume)
                    .HasColumnName("COMPLET_VOLUME")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.Fee)
                    .HasColumnName("FEE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.Source).HasColumnName("SOURCE");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TriggerId)
                    .HasColumnName("TRIGGER_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("decimal(28, 12)");
            });

            modelBuilder.Entity<TblOrderTradeArchive>(entity =>
            {
                entity.ToTable("TBL_ORDER_TRADE_ARCHIVE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandCode).HasColumnName("COMMAND_CODE");

                entity.Property(e => e.CompletAmount)
                    .HasColumnName("COMPLET_AMOUNT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.CompletVolume)
                    .HasColumnName("COMPLET_VOLUME")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.Fee)
                    .HasColumnName("FEE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.Source).HasColumnName("SOURCE");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TriggerId)
                    .HasColumnName("TRIGGER_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Volume)
                    .HasColumnName("VOLUME")
                    .HasColumnType("decimal(28, 12)");
            });

            modelBuilder.Entity<TblOrderTransfer>(entity =>
            {
                entity.ToTable("TBL_ORDER_TRANSFER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.CommandCode).HasColumnName("COMMAND_CODE");

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.FromAccountId)
                    .IsRequired()
                    .HasColumnName("FROM_ACCOUNT_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FromMarketCoinCode).HasColumnName("FROM_MARKET_COIN_CODE");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Source).HasColumnName("SOURCE");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.ToAccountId)
                    .IsRequired()
                    .HasColumnName("TO_ACCOUNT_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ToMarketCoinCode).HasColumnName("TO_MARKET_COIN_CODE");
            });

            modelBuilder.Entity<TblStandardCode>(entity =>
            {
                entity.ToTable("TBL_STANDARD_CODE");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("IDX_GROUP_CODE");

                entity.HasIndex(e => new { e.GroupCode, e.SubCode })
                    .HasName("IDX_GROUP_STANDARD_CODE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(200);

                entity.Property(e => e.DisplayNameEng)
                    .HasColumnName("DISPLAY_NAME_ENG")
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayNameKor)
                    .HasColumnName("DISPLAY_NAME_KOR")
                    .HasMaxLength(100);

                entity.Property(e => e.GroupCode).HasColumnName("GROUP_CODE");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.StandardCodeName)
                    .IsRequired()
                    .HasColumnName("STANDARD_CODE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.SubCode).HasColumnName("SUB_CODE");
            });

            modelBuilder.Entity<TblTempResult>(entity =>
            {
                entity.ToTable("TBL_TEMP_RESULT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommandId)
                    .IsRequired()
                    .HasColumnName("COMMAND_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CommandType).HasColumnName("COMMAND_TYPE");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("RESULT")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<TblTradeAccount>(entity =>
            {
                entity.ToTable("TBL_TRADE_ACCOUNT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.Loan)
                    .HasColumnName("LOAN")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.MarketCoinCode)
                    .HasColumnName("MARKET_COIN_CODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Reserved)
                    .HasColumnName("RESERVED")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("TOTAL_AMOUNT")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.UpdateTime).HasColumnName("UPDATE_TIME");
            });

            modelBuilder.Entity<TblTriggerOrder>(entity =>
            {
                entity.ToTable("TBL_TRIGGER_ORDER");

                entity.HasIndex(e => new { e.MarketCode, e.Owner, e.State })
                    .HasName("IX_TBL_TRIGGER_ORDER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandCode).HasColumnName("COMMAND_CODE");

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.InvestedType).HasColumnName("INVESTED_TYPE");

                entity.Property(e => e.MarketCode)
                    .HasColumnName("MARKET_CODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderPrice)
                    .HasColumnName("ORDER_PRICE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatType).HasColumnName("REPEAT_TYPE");

                entity.Property(e => e.Source).HasColumnName("SOURCE");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TriggerCommandCode).HasColumnName("TRIGGER_COMMAND_CODE");

                entity.Property(e => e.TriggerPrice)
                    .HasColumnName("TRIGGER_PRICE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.TriggerVolume)
                    .HasColumnName("TRIGGER_VOLUME")
                    .HasColumnType("decimal(28, 12)");
            });

            modelBuilder.Entity<TblTriggerPrice>(entity =>
            {
                entity.ToTable("TBL_TRIGGER_PRICE");

                entity.HasIndex(e => new { e.MarketCode, e.Owner, e.State })
                    .HasName("IX_TBL_TRIGGER_PRICE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandCode).HasColumnName("COMMAND_CODE");

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.MarketCode).HasColumnName("MARKET_CODE");

                entity.Property(e => e.OrderCommandCode).HasColumnName("ORDER_COMMAND_CODE");

                entity.Property(e => e.OrderPrice)
                    .HasColumnName("ORDER_PRICE")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.OrderVolume)
                    .HasColumnName("ORDER_VOLUME")
                    .HasColumnType("decimal(28, 12)");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Source).HasColumnName("SOURCE");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TriggerPrice)
                    .HasColumnName("TRIGGER_PRICE")
                    .HasColumnType("decimal(28, 12)");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("TBL_USER");

                entity.HasIndex(e => e.MbEmail)
                    .HasName("IX_TBL_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthCheck)
                    .HasColumnName("AUTH_CHECK")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnName("CREATE_TIME");

                entity.Property(e => e.LastHistoryTime).HasColumnName("LAST_HISTORY_TIME");

                entity.Property(e => e.LoginTime).HasColumnName("LOGIN_TIME");

                entity.Property(e => e.MarginCallCheckTimeTick)
                    .HasColumnName("MARGIN_CALL_CHECK_TIME_TICK")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MbEmail)
                    .IsRequired()
                    .HasColumnName("MB_EMAIL")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MbHp)
                    .HasColumnName("MB_HP")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MbLevel)
                    .HasColumnName("MB_LEVEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MbPassword)
                    .IsRequired()
                    .HasColumnName("MB_PASSWORD")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyCheck)
                    .HasColumnName("NOTIFY_CHECK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtpCodeEnc)
                    .HasColumnName("OTP_CODE_ENC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasColumnName("STATE");
            });

            modelBuilder.Entity<TblUserAction>(entity =>
            {
                entity.ToTable("TBL_USER_ACTION");

                entity.HasIndex(e => e.UserEmail)
                    .HasName("IX_TBL_USER_ACTION");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("ACTION")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ActionTime).HasColumnName("ACTION_TIME");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Platform).HasColumnName("PLATFORM");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("RESULT")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SESSION_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("USER_EMAIL")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWalletAccount>(entity =>
            {
                entity.ToTable("TBL_WALLET_ACCOUNT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountBankCode).HasColumnName("ACCOUNT_BANK_CODE");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MarketCoinCode).HasColumnName("MARKET_COIN_CODE");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("OWNER")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Reserved)
                    .HasColumnName("RESERVED")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.TradeAccountId)
                    .IsRequired()
                    .HasColumnName("TRADE_ACCOUNT_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.WalletIdx).HasColumnName("WALLET_IDX");
            });

            modelBuilder.Entity<TblWalletAccountPool>(entity =>
            {
                entity.HasKey(e => new { e.MarketCoinCode, e.WalletIdx, e.AccountBankCode, e.AccountId });

                entity.ToTable("TBL_WALLET_ACCOUNT_POOL");

                entity.Property(e => e.MarketCoinCode)
                    .HasColumnName("MARKET_COIN_CODE")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.WalletIdx).HasColumnName("WALLET_IDX");

                entity.Property(e => e.AccountBankCode).HasColumnName("ACCOUNT_BANK_CODE");

                entity.Property(e => e.AccountId)
                    .HasColumnName("ACCOUNT_ID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasColumnName("STATE");
            });

            modelBuilder.Entity<TblWalletBankInfo>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("TBL_WALLET_BANK_INFO");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Info)
                    .HasColumnName("INFO")
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(128);

                entity.Property(e => e.State).HasColumnName("STATE");
            });
        }
    }
}
