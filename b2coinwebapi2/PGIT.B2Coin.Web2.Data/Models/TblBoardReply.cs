using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblBoardReply
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string UserEmail { get; set; }
        public string Content { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
