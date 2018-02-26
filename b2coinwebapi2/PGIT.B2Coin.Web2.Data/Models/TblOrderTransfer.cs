using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblOrderTransfer
    {
        public string Id { get; set; }
        public int Source { get; set; }
        public string Owner { get; set; }
        public int CommandCode { get; set; }
        public DateTime CreateTime { get; set; }
        public int FromMarketCoinCode { get; set; }
        public string FromAccountId { get; set; }
        public int ToMarketCoinCode { get; set; }
        public string ToAccountId { get; set; }
        public decimal Amount { get; set; }
        public int State { get; set; }
    }
}
