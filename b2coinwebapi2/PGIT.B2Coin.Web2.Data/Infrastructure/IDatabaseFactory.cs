namespace PGIT.B2Coin.Web2.Data.Infrastructure
{
    using System;
    using Models;

    public interface IDatabaseFactory : IDisposable
    {
        B2CoinEntites Get();
    }
}
