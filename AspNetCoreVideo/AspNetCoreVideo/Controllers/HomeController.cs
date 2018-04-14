using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Models;
using AspNetCoreVideo.Services;

namespace AspNetCoreVideo.Controllers
{
    public class HomeController : Controller
    {

        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll();
            return View(model);
        }
    }
}
