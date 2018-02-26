namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblCfgMarket
    {
        public int MarketCode { get; set; }
        public string Info { get; set; }
        public int MaxQueueCount { get; set; }
        public decimal TradeFeeSell { get; set; }
        public decimal TradeFeeBuy { get; set; }
        public decimal TradeFeeMaker { get; set; }
        public decimal TradeFeeTaker { get; set; }
        public int LiveTradeCount { get; set; }
        public int OrderBookCount { get; set; }
        public int State { get; set; }
    }
}
