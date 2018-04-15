using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Models;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}
