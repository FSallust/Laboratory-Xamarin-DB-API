using DAL.interfaces;
using DemoAPI.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _service;

        public CategoryController(ICategoryService categoryService)
        {
            _service = categoryService;
        }

        //https://localhost:port/api/category
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            return Ok(_service.GetAll().Select(m => m.ToAPI()));
        }

        //https://localhost:port/api/category/1
        [HttpGet("{Id}")]
        public IActionResult GetCategoryById(int Id)
        {
            return Ok(_service.GetById(Id).ToAPI());
        }
    }
}
