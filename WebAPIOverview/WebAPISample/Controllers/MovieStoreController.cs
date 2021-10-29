using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPISample.Data;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieStoreController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MovieStoreController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Movie>> GetAll()
        {
            return _context.Movie.ToList();
        }

        [HttpGet("GetById/{id:int}")]
        public ActionResult<Movie> GetAll(int id)
        {
            return _context.Movie.Single(n => n.Id == id);
        }

        [HttpGet("GetWithPagging/")]
        public ActionResult<IEnumerable<Movie>> EasyPagingList(int pageNumber=1, int pageSize=5)
        {
            return _context.Movie.OrderBy(o => o.Name)
                                         .Skip((pageNumber - 1) * pageSize)
                                         .Take(pageSize).ToList();
        }

        [HttpGet("PagingListWithPageParametersObject/")]
        public ActionResult<IEnumerable<Movie>> EasyPagingList([FromQuery] PageParameters pageParameters)
        {
            return _context.Movie.OrderBy(o => o.Name)
                                         .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                                         .Take(pageParameters.PageSize).ToList();
        }



    }
}
