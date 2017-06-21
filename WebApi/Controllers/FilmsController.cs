using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http;
using WebApi.Client;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class FilmsController : Controller
    {
        private IMemoryCache _cache;

        public FilmsController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }

        public async Task<IList<FilmModel>> Get()
        {
            //TODO: add output cache

            IList<FilmModel> cacheEntry;

            //Look for memory cache key.
            if (!_cache.TryGetValue("cachedMovies", out cacheEntry))
            {
                // Key not in cache, so get data.
                TiffClient client = new TiffClient();
                cacheEntry = await client.GetFilms();

                // Set cache options.
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Keep in cache for this time
                    .SetAbsoluteExpiration(TimeSpan.FromHours(12));

                // Save data in cache.
                _cache.Set("cachedMovies", cacheEntry, cacheEntryOptions);
            }

            return cacheEntry;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
