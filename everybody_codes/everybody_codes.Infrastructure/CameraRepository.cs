using everybody_codes.Domain.CameraAggregate;
using everybody_codes.Infrastructure.CSVParsing.Cameras;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace everybody_codes.Infrastructure
{
    public class CameraRepository : ICameraRepository
    {
        private readonly CameraCsvParser _cameraCsvParser;
        private readonly IConfiguration _configuration;

        public CameraRepository(IConfiguration configuration, ILogger<CameraRepository> logger)
        {
            _configuration = configuration;
            _cameraCsvParser = new CameraCsvParser(logger);
        }

        public IList<Camera> GetCameras()
        {
            var camerasCSVFilepath = AppDomain.CurrentDomain.BaseDirectory + _configuration["CamerasCSVFilename"];

            return _cameraCsvParser.Parse(camerasCSVFilepath);
        }
    }
}
