namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblWalletAccount
    {
        public string Id { get; set; }
        public int MarketCoinCode { get; set; }
        public int WalletIdx { get; set; }
        public string Owner { get; set; }
        public string TradeAccountId { get; set; }
        public int? AccountBankCode { get; set; }
        public string AccountId { get; set; }
        public string Reserved { get; set; }
        public int State { get; set; }
    }
}
