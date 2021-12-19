using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
  public  interface  IFavoriteCitysDL
    {
        List<FavoriteCitys> GetCitysById(string id);

        string AddCity(FavoriteCitys favoriteCitys);
        List<FavoriteCitys> DeleteCityById(string idUser, string idCity);
    }
}
