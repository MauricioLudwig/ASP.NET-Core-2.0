using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Entities;

namespace AspNetCoreVideo.Services
{
    public interface IVideoData
    {
        Video Get(int id);
        IEnumerable<Video> GetAll();
    }
}
