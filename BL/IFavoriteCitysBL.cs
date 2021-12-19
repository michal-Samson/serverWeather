using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
   public interface IFavoriteCitysBL
    {
        List<FavoriteCitys> GetCitysById(string id);
        string AddCity(FavoriteCitys favoriteCitys);
        List<FavoriteCitys> DeleteCityById(string idUser,string idCity );
    }
}
