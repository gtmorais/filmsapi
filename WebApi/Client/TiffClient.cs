using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Client
{
    public class TiffClient
    {
        public async Task<List<FilmModel>> GetFilms()
        {
            //TODO: move to config file
            string url = "http://www.tiff.net/data/films.json";
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var content = response.Content.ReadAsStringAsync().Result;

                    var item = JsonConvert.DeserializeObject<List<FilmModel>>(JsonConvert.SerializeObject(JArray.Parse(content)));

                    return item;
                }
                catch (Exception ex) {
                    //TODO: log error 
                    return null;
                }
            }
            else
                return null;
        }
    }
}
