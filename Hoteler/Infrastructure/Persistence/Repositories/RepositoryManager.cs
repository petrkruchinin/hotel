using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly Lazy<IRoomRepository> _lazyRoomRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyRoomRepository = new Lazy<IRoomRepository>(() => new RoomRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;

        public IRoomRepository RoomRepository => _lazyRoomRepository.Value;
    }
}
