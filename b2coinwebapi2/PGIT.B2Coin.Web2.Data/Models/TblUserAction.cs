using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblUserAction
    {
        public string Id { get; set; }
        public string SessionId { get; set; }
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string Action { get; set; }
        public DateTime ActionTime { get; set; }
        public string Result { get; set; }
        public int Platform { get; set; }
        public string Ip { get; set; }
        public string CountryCode { get; set; }
    }
}
