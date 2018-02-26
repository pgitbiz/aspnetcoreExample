using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblTradeAccount
    {
        public string Id { get; set; }
        public int MarketCoinCode { get; set; }
        public string Owner { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int State { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Loan { get; set; }
        public decimal Reserved { get; set; }
    }
}
