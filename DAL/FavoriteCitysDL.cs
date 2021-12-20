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
        public string AddCity(FavoriteCitys favoriteCitys)
        {
            if (DB.FavoriteCitys.Count(u => u.IdUser == favoriteCitys.IdUser && u.IdName == favoriteCitys.IdName) < 1)
            {
                DB.FavoriteCitys.Add(favoriteCitys);
                DB.SaveChanges();
                return ("save");
            }
            return ("no");
        }
        public List<FavoriteCitys> DeleteCityById(string idUser, string idCity)
        {
        https://localhost:44342/DB.FavoriteCitys.Remove(DB.FavoriteCitys.Where(u => u.IdUser == idUser && u.IdName == idCity).FirstOrDefault());
            DB.SaveChanges();
                return (DB.FavoriteCitys.Where(f => f.IdUser == idUser).ToList());
        }
    }

}
