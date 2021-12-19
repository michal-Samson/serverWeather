using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class FavoriteCitys
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public string IdName { get; set; }
        public string CityName { get; set; }
        public string WeatherText { get; set; }
        public int Temp { get; set; }
    }
}
