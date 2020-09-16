using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace everybody_codes.Infrastructure.CSVParsing.Cameras
{
    class CameraCsvConfigCreator
    {
        private CsvConfiguration defaultConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture);

        public CsvConfiguration GetDefault()
        {
            defaultConfiguration.Delimiter = ";";
            defaultConfiguration.ShouldSkipRecord = record => IsRecordInvalid(record);
            RegisterMappings();

            return defaultConfiguration;
        }

        private void RegisterMappings()
        {
            defaultConfiguration.RegisterClassMap<CameraMap>();
        }

        private bool IsRecordInvalid(string[] record)
        {
            return IsRecordError(record) || IsRecordEmpty(record);
        }

        private bool IsRecordEmpty(string[] record)
        {
            return record.All(field => string.IsNullOrWhiteSpace(field));
        }

        private bool IsRecordError(string[] record)
        {
            return record[0].StartsWith("ERROR");
        }
    }
}
