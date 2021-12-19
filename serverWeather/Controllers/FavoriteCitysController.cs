using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
namespace serverWeather.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FavoriteCitysController : ControllerBase
    {
        private readonly IFavoriteCitysBL favoriteCitysBL ;
        // GET: <controller>
        public FavoriteCitysController(IFavoriteCitysBL _favoriteCitysBL)

        {
            this.favoriteCitysBL = _favoriteCitysBL ;
        }

        [HttpGet("Get")]
        public ActionResult <List<FavoriteCitys>> Get(string id)
        {
            return favoriteCitysBL.GetCitysById(id);
        }

        [HttpPost]
        [Route("AddCity")]
        public void AddCity(FavoriteCitys favoriteCitys)
        {

            favoriteCitysBL.AddCity(favoriteCitys);

        }
        [HttpDelete("DeleteCityById")]
        public void DeleteCityById(string id )
        {
            var idUser = id.Split("@")[0];
            var idName = id.Split("@")[1];

            favoriteCitysBL.DeleteCityById(idUser, idName);

        }



    }
}
