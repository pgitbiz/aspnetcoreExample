namespace PGIT.B2Coin.Web2.Data.Infrastructure
{
    using Models;

    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private B2CoinEntites _dataContext;

        public B2CoinEntites Get()
            => _dataContext ?? (_dataContext = new B2CoinEntites());

        protected override void DisposeCore()
            => _dataContext?.Dispose();
    }
}
