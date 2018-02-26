using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblUser
    {
        public string Id { get; set; }
        public string MbPassword { get; set; }
        public string MbEmail { get; set; }
        public string MbHp { get; set; }
        public int MbLevel { get; set; }
        public string NotifyCheck { get; set; }
        public string AuthCheck { get; set; }
        public string OtpCodeEnc { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LastHistoryTime { get; set; }
        public long MarginCallCheckTimeTick { get; set; }
        public int State { get; set; }
    }
}
