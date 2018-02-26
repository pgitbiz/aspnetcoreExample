using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblTriggerOrder
    {
        public string Id { get; set; }
        public int Source { get; set; }
        public int MarketCode { get; set; }
        public string Owner { get; set; }
        public int CommandCode { get; set; }
        public DateTime CreateTime { get; set; }
        public int RepeatType { get; set; }
        public int InvestedType { get; set; }
        public int TriggerCommandCode { get; set; }
        public decimal TriggerPrice { get; set; }
        public decimal TriggerVolume { get; set; }
        public decimal OrderPrice { get; set; }
        public int State { get; set; }
    }
}
