using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblOrderTradeArchive
    {
        public string Id { get; set; }
        public int Source { get; set; }
        public int MarketCode { get; set; }
        public string Owner { get; set; }
        public int CommandCode { get; set; }
        public DateTime CreateTime { get; set; }
        public string TriggerId { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
        public decimal CompletAmount { get; set; }
        public decimal CompletVolume { get; set; }
        public decimal Fee { get; set; }
        public int State { get; set; }
    }
}
