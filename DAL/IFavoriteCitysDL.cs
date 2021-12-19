using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
  public  interface  IFavoriteCitysDL
    {
        List<FavoriteCitys> GetCitysById(string id);

        void AddCity(FavoriteCitys favoriteCitys);
        void DeleteCityById(string idUser, string idCity);
    }
}
