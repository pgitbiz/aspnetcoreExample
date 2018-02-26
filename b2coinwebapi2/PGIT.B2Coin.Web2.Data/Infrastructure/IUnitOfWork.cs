namespace PGIT.B2Coin.Web2.Data.Infrastructure
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
