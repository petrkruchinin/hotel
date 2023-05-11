using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Repositories;

using Services.Abstractions;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IRoomService> _lazyOwnerService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyOwnerService = new Lazy<IRoomService>(() => new RoomService(repositoryManager));
        }

        public IRoomService RoomService => _lazyOwnerService.Value;
    }
}
