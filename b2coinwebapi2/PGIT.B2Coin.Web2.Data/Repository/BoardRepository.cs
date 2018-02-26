namespace PGIT.B2Coin.Web2.Data.Repository
{
    using Infrastructure;
    using Models;

    public class BoardRepository : RepositoryBase<TblBoard>, IBoardRepository
    {
        public BoardRepository(IDatabaseFactory databaseFactory) 
            : base(databaseFactory) { }
        
    }

    public interface IBoardRepository : IRepository<TblBoard> { }
}
