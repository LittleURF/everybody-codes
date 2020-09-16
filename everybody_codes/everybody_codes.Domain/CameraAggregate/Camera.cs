using System;
using System.Collections.Generic;
using System.Text;

namespace everybody_codes.Domain.CameraAggregate
{
    public class Camera
    {
        // privates + ctor
        public string Name { get; set; }
        public int Number { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
