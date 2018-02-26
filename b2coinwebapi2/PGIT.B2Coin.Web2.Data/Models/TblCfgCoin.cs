namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblCfgCoin
    {
        public int CoinCode { get; set; }
        public string Info { get; set; }
        public decimal InterestRate { get; set; }
        public decimal LoanFee { get; set; }
        public decimal MaxLoanVolumeSpot { get; set; }
        public decimal WithdrawFeeRate { get; set; }
        public decimal MinTradeVolume { get; set; }
        public decimal MaxWithdrawOnce { get; set; }
        public decimal MaxWithdrawDay { get; set; }
        public int LoanState { get; set; }
        public int WithdrawState { get; set; }
        public int ConfirmRepeat { get; set; }
        public int ConfirmWithdraw { get; set; }
        public int Precision { get; set; }
        public int PrecisionVolume { get; set; }
        public int WalletIssuedIdx { get; set; }
        public int State { get; set; }
    }
}
