namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblCfgUserLevel
    {
        public int UserLevel { get; set; }
        public string Info { get; set; }
        public decimal TradeFeeDiscount { get; set; }
        public decimal LoanFeeDiscount { get; set; }
        public decimal WithdrawFeeDiscount { get; set; }
        public int OrderCount { get; set; }
        public int TriggerCount { get; set; }
        public int State { get; set; }
    }
}
