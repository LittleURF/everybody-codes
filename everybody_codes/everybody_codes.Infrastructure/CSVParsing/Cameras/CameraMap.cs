using CsvHelper;
using CsvHelper.Configuration;
using everybody_codes.Domain.CameraAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace everybody_codes.Infrastructure.CSVParsing.Cameras
{
    public class CameraMap : ClassMap<Camera>
    {
        public CameraMap()
        {
            Map(c => c.Name).Name("Camera");
            Map(c => c.Number).ConvertUsing(row => GetCameraNumber(row));
            Map(c => c.Latitude).Name("Latitude");
            Map(c => c.Longitude).Name("Longitude");
        }

        private int GetCameraNumber(IReaderRow row)
        {
            var cameraField = row.GetField("Camera");

            var cameraNumber = Int32.Parse(cameraField.Substring(7, 3));
            return cameraNumber;
        }
    }
}
