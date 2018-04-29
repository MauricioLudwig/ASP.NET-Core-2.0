﻿using Microsoft.AspNetCore.Mvc;
using AspNetCoreVideo.Services;
using System;
using System.Linq;
using AspNetCoreVideo.Models;
using AspNetCoreVideo.ViewModels;
using AspNetCoreVideo.Entities;
using Microsoft.AspNetCore.Authorization;

namespace AspNetCoreVideo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        [AllowAnonymous]
        [HttpGet]
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

        [HttpGet]
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VideoEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                var video = new Video
                {
                    Title = model.Title,
                    Genre = model.Genre
                };
                _videos.Add(video);
                _videos.Commit();
                return RedirectToAction("Details", new { id = video.Id });

            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var video = _videos.Get(id);

            if (video == null)
                return RedirectToAction(nameof(HomeController.Index));

            return View(video);
        }

        [HttpPost]
        public IActionResult Edit(int id, VideoEditViewModel model)
        {
            var video = _videos.Get(id);

            if (video == null || !ModelState.IsValid)
                return View(model);

            video.Title = model.Title;
            video.Genre = model.Genre;

            _videos.Commit();

            return RedirectToAction("Details", new {  id = video.Id });
        }

    }
}
