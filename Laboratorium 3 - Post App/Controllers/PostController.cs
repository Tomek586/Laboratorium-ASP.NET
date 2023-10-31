using Laboratorium_3___Post_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___Post_App.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            var x = _postService.FindAll();
            return View(x);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post model)
        {
            if (ModelState.IsValid)
            {
                _postService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var post = _postService.FindById(id);
            return View(post);
        }

        [HttpPost]
        public IActionResult Update(Post model)
        {
            if (ModelState.IsValid)
            {
                _postService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var post = _postService.FindById(id);
            return View(post);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var post = _postService.FindById(id);
            if (post == null)
            {
                return NotFound();
            }

            _postService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
