using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPISample.Services
{
    public interface IVideoStream
    {
        Task<Stream> GetVideoByName(string name);
    }
}
