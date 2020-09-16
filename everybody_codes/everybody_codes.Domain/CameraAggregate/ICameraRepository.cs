using System;
using System.Collections.Generic;
using System.Text;

namespace everybody_codes.Domain.CameraAggregate
{
    public interface ICameraRepository
    {
        IList<Camera> GetCameras();
    }
}
