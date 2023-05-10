using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public RoomRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;


        public Task<IEnumerable<Room>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Insert(Room room)
        {
            throw new NotImplementedException();
        }

        public void Remove(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
