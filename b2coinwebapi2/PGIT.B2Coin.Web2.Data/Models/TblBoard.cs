using System;

namespace PGIT.B2Coin.Web2.Data.Models
{
    public class TblBoard
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string UserEmail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserHp { get; set; }
        public string State { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
