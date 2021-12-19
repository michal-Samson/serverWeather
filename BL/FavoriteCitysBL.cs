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
        public void AddCity(FavoriteCitys favoriteCitys)
        {
            favoriteCitysDL.AddCity(favoriteCitys);
        }

        public void DeleteCityById(string idUser, string idCity)
        {
            favoriteCitysDL.DeleteCityById(idUser, idCity);
        }
    }
}
