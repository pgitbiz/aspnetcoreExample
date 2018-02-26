namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblWalletAccountPool
    {
        public string MarketCoinCode { get; set; }
        public int WalletIdx { get; set; }
        public int AccountBankCode { get; set; }
        public string AccountId { get; set; }
        public int State { get; set; }
    }
}
