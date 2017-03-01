using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Album.DataAccess.EF.Repository;
using Album.DataAccess.EF.Models;
using Microsoft.Extensions.Logging;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbumsCoreApi
{
    //[Route("api/[controller]")]
    public class AlbumApiController : Controller
    {

        private readonly AlbumViewerContext _context;

        private readonly ArtistRepository _artistRepository;

        private readonly ILogger _logger;



        public AlbumApiController(AlbumViewerContext context, ArtistRepository artistRepository, ILogger<AlbumApiController> logger)
        {
            this._context = context;

            this._artistRepository = artistRepository;

            this._logger = logger;
        }


     


        //// GET: api/values
        //[HttpGet]
        //[Route("api/helloworld")]
        //public object HelloWorld(string name = null)
        //{
        //    if (string.IsNullOrEmpty(name))
        //        name = "Johnny Doe";


        //    return new
        //    {
        //        message = $"Hello world {name}",
        //        time = DateTime.UtcNow
        //    };
        //}
        //// GET api/values/5
        //[HttpGet("api/helloworld/{id}")]
        //public string Get(int id)
        //{
        //    return "hello world";
        //}


      

        [HttpGet("api/artists")]
        public async Task<List<Artist>> GetArtists()
        {


            this._logger.LogInformation("Getting artists...");

            return await this._artistRepository.GetArtists();

            
            

        }


        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
