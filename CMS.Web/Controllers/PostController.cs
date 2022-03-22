using CMS.Core.Constants;
using CMS.Core.Dtos;
using CMS.Core.Enums;
using CMS.Infrastructure.Services.Categories;
using CMS.Infrastructure.Services.Posts;
using CMS.Infrastructure.Services.Tracks;
using CMS.Infrastructure.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Controllers
{
    public class PostController : BaseController
    {
        private readonly IPostService _postService;
        private readonly ICategoryService _categoryService;

        public PostController(IPostService postService, ICategoryService categoryService, IUserService userService):base(userService)
        {
           _categoryService = categoryService;
           _postService = postService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetLog (int Id)
        {
            var logs =await _postService.GetLog(Id);
            return View(logs);

        }
        public async Task<JsonResult> GetPostsData(Pagination pagination, Query query)
        {
            var result = await _postService.GetAll(pagination, query);
            return Json(result);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewData["categories"] = new SelectList(await _categoryService.GetCategoryList(), "Id", "Name");
            ViewData["authores"] = new SelectList(await _userService.GetAuthorList(), "Id", "FullName");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePostDto dto)
        {
            if (ModelState.IsValid)
            {
                await _postService.Create(dto);
                return Ok(Results.AddSuccessResult());

            }
            ViewData["categories"] = new SelectList(await _categoryService.GetCategoryList(), "Id", "Name");
            ViewData["authores"] = new SelectList(await _userService.GetAuthorList(), "Id", "FullName");

            return View(dto);
        }
        //[HttpGet]
        //public async Task<IActionResult> Update(int id)
        //{
        //    ViewData["categories"] = new SelectList(await _categoryService.GetCategoryList(), "Id", "Name");
        //    ViewData["authores"] = new SelectList(await _userService.GetAuthorList(), "Id", "FullName");

        //    var advertisement = await _postService.Get(id);
        //    return View(advertisement);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Update(UpdatePostDto dto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _postService.Update(dto);
        //        return Ok(Results.EditSuccessResult());
        //    }
        //    ViewData["categories"] = new SelectList(await _categoryService.GetCategoryList(), "Id", "Name");
        //    ViewData["authores"] = new SelectList(await _userService.GetAuthorList(), "Id", "FullName");


        //    return View(dto);
        //}
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _postService.Delete(id);
            return Ok(Results.DeleteSuccessResult());
        }
        public async Task<IActionResult> UpdateStatus(int id,ContentStatus status)
        {
            await _postService.UpdateStatus(id,status);
            return Ok(Results.UpdateStatusSuccessResult());
        }
        //[HttpPost]
        //public IActionResult ExportExel()
        //{
        //    return View();
        //}
    }

}

