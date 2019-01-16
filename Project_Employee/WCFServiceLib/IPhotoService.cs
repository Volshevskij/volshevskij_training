using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceLib
{
    
    [ServiceContract]
    public interface IPhotoService
    {
        [OperationContract]
        byte[] GetPhoto(string path);
    }
}
