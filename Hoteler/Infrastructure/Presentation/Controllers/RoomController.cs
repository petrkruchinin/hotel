using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/room")]
    public class RoomController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public RoomController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
        }

    }
}
