using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblLogWallet
    {
        public string TxId { get; set; }
        public int MarketCoinCode { get; set; }
        public int WalletIdx { get; set; }
        public DateTime ReceivedTime { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public decimal Amount { get; set; }
        public int Confirmations { get; set; }
        public int State { get; set; }
    }
}
