using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Models;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {

        private IEnumerable<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Title = "The Fellowship of the Ring" },
                new Video { Id = 2, Title = "The Two Towers"},
                new Video { Id = 3, Title = "The Return of the King"}
            };
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
    }
}
