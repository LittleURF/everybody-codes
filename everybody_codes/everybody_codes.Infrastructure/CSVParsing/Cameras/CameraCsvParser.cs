using CsvHelper;
using CsvHelper.Configuration;
using everybody_codes.Domain.CameraAggregate;
using everybody_codes.Infrastructure.CSVParsing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace everybody_codes.Infrastructure.CSVParsing.Cameras
{
    public class CameraCsvParser
    {
        private readonly CameraCsvConfigCreator _csvConfigCreator = new CameraCsvConfigCreator();
        private readonly ILogger _logger;

        public CameraCsvParser(ILogger logger)
        {
            _logger = logger;
        }

        public IList<Camera> Parse(string filepath)
        {
            try
            {
                using (var reader = new StreamReader(filepath))
                using (var csv = new CsvReader(reader, _csvConfigCreator.GetDefault()))
                {
                    return csv.GetRecords<Camera>().ToList();
                }
            }
            catch (FileNotFoundException ex)
            {
                _logger.LogError(ex, "The CSV File containing cameras data was not found.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured during parsing of the CSV Cameras file");
                throw;
            }

        }
    }
}
