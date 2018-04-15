using Microsoft.AspNetCore.Mvc;
using AspNetCoreVideo.Services;
using System;
using System.Linq;
using AspNetCoreVideo.Models;
using AspNetCoreVideo.ViewModels;

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
            var model = _videos.GetAll().Select(video =>
            new VideoViewModel
            {
                Id = video.Id,
                Title = video.Title,
                Genre = video.Genre.ToString()
            });
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _videos.Get(id);

            if (model == null)
                return RedirectToAction(nameof(HomeController.Index));

            return View(new VideoViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Genre = model.Genre.ToString()
            });
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
