using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class FavoriteCitysDL : IFavoriteCitysDL
    { 
        private readonly weather_DBContext DB;
        public FavoriteCitysDL(weather_DBContext _DB)

        {
            this.DB = _DB;
        }
        public List<FavoriteCitys> GetCitysById(string id)
        {
            return (DB.FavoriteCitys.Where(f => f.IdUser == id).ToList());
        }
        public void AddCity(FavoriteCitys favoriteCitys)
        {
            
                DB.FavoriteCitys.Add(favoriteCitys);
                DB.SaveChanges();
            
        }

        public void DeleteCityById(string idUser, string idCity)
        {
            DB.FavoriteCitys.Remove(DB.FavoriteCitys.Where(u => u.IdUser == idUser && u.IdName == idCity).FirstOrDefault());
            DB.SaveChanges();
        }
    }

}
