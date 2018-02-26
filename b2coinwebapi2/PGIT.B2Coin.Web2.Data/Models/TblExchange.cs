using System;
namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblExchange
    {
        public string Id { get; set; }
        public int MarketCode { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
        public int Side { get; set; }
        public DateTime CreateTime { get; set; }
        public int State { get; set; }
        public string BuyOrderId { get; set; }
        public string BuyOwner { get; set; }
        public string SellOrderId { get; set; }
        public string SellOwner { get; set; }
    }
}
