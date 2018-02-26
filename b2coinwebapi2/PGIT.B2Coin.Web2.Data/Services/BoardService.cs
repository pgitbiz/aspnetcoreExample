namespace PGIT.B2Coin.Web2.Data.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Infrastructure;
    using Models;
    using Repository;

    public interface IBoardService
    {
        Task<TblBoard> GetBoardInfoAsync(int id);

        Task<IEnumerable<TblBoard>> GetBoardInfoByUserNameAsync(string eMail);

        Task<TblBoard> CreateBoardAsync(TblBoard board);

        Task UpdateBoardAsync(TblBoard board);

        Task DeleteBoardAsync(int id);

        Task<IEnumerable<TblBoard>> GetBoardPageInfoAsync(string eMail, Page page);

        Task<int> GetBoardCountAsync(string eMail);
    }

    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IUnitOfWork _untUnitOfWork;

        public BoardService(IBoardRepository boardRepository, IUnitOfWork unitOfWork)
        {
            _boardRepository = boardRepository ?? 
                throw new ArgumentNullException(nameof(boardRepository));
            _untUnitOfWork = unitOfWork ?? 
                throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<TblBoard> GetBoardInfoAsync(int id)
            => await _boardRepository.GetAsync(b => b.Id == id);

        public async Task<IEnumerable<TblBoard>> GetBoardInfoByUserNameAsync(string eMail)
            => await _boardRepository.GetManyAsync(u => u.UserEmail == eMail);

        public async Task<TblBoard> CreateBoardAsync(TblBoard board)
        {
            _boardRepository.Add(board);
            await SaveBoardAsync();
            return board;
        }

        public async Task UpdateBoardAsync(TblBoard board)
        {
            _boardRepository.Update(board);
            await SaveBoardAsync();
        }

        public async Task DeleteBoardAsync(int id)
        {
            _boardRepository.Delete(b => b.Id == id);
            await SaveBoardAsync();
        }

        public Task<IEnumerable<TblBoard>> GetBoardPageInfoAsync(string eMail, Page page)
            => _boardRepository.GetPageDescendingAsync(page, w => w.UserEmail == eMail, 
                x => x.RegDate);

        public Task<int> GetBoardCountAsync(string eMail)
            => _boardRepository.GetCountAsync(x => x.UserEmail == eMail);

        private Task SaveBoardAsync() => _untUnitOfWork.CommitAsync();
    }

    
}
