using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Models;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {

        private List<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Genre = Genres.Animated, Title = "The Fellowship of the Ring" },
                new Video { Id = 2, Genre = Genres.Action, Title = "The Two Towers"},
                new Video { Id = 3, Genre = Genres.Romance, Title = "The Return of the King"}
            };
        }

        public void Add(Video newVideo)
        {
            newVideo.Id = _videos.Max(o => o.Id) + 1;
            _videos.Add(newVideo);
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(o => o.Id.Equals(id));
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
    }
}
