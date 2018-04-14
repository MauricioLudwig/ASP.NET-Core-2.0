using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Models;

namespace AspNetCoreVideo.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
    }
}
