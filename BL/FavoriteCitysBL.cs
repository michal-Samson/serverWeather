using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace BL
{
    public class FavoriteCitysBL : IFavoriteCitysBL
    {

        private readonly IFavoriteCitysDL favoriteCitysDL;
        public FavoriteCitysBL(IFavoriteCitysDL _favoriteCitysDL)
        {
            this.favoriteCitysDL = _favoriteCitysDL;
        }
        public List<FavoriteCitys> GetCitysById(string id)
        {
            return (favoriteCitysDL.GetCitysById(id));
        }
        public string AddCity(FavoriteCitys favoriteCitys)
        {
           return favoriteCitysDL.AddCity(favoriteCitys);
        }

        public List<FavoriteCitys> DeleteCityById(string idUser, string idCity)
        {
           return favoriteCitysDL.DeleteCityById(idUser, idCity);
        }
    }
}
