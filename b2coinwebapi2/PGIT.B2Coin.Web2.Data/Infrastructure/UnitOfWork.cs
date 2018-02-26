namespace PGIT.B2Coin.Web2.Data.Infrastructure
{
    using System.Threading.Tasks;
    using Models;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;
        private B2CoinEntites _dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
            => _databaseFactory = databaseFactory;

        protected B2CoinEntites DataContext
            => _dataContext ?? (_dataContext = _databaseFactory.Get());

        public async Task CommitAsync() => await DataContext.CommitAsync();

        public void Commmit() => DataContext.Commit();
    }
}
