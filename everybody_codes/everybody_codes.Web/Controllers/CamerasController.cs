using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using everybody_codes.Domain.CameraAggregate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace everybody_codes.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CamerasController : ControllerBase
    {
        private readonly ICameraRepository _cameraRepository;

        public CamerasController(ICameraRepository cameraRepository)
        {
            _cameraRepository = cameraRepository;
        }

        [HttpGet]
        public IList<Camera> Get()
        {
            return _cameraRepository.GetCameras();
        }
    }
}
