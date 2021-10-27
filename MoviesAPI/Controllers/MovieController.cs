using DAL.interfaces;
using DemoAPI.Tools;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService _service;

        public MovieController(IMovieService movieService) 
        {
            _service = movieService;
        }

        //https://localhost:port/api/movie
        [HttpGet]
        public IActionResult GetMovieList()
        {
            return Ok(_service.GetAll().Select(m => m.ToAPI()));
        }

        //https://localhost:port/api/movie/1
        [HttpGet("{Id}")]
        public IActionResult GetMovieByCategoryId(int Id)
        {
            return Ok(_service.GetByCategoryId(Id).Select(m => m.ToAPI()));
        }
    }
}
