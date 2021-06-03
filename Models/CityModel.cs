using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Models
{
    public class CityModel
    {
        public string CountryCode { get; set; }
        public string CityCode { get; set; }

        public string City { get; set; }

        public CountryModel Country { get; set; }

        public List<CityModel> GetCitities()
            {
            return new List<CityModel>
        {
            new CityModel { CountryCode = "IN", CityCode="KA",City = "Kolkata" },
            new CityModel {  CountryCode = "IN", CityCode="MB",City = "Mumbai" },
            new CityModel { CountryCode = "US", CityCode="CH",City = "Chicago"  },
        };
        }
       
    }
}
