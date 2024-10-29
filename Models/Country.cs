using Core.Helper.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Country
    {
        public Country(string countryName, int areas, string anthem)
        {
            ++_countryId;
            CountryId = _countryId;
           
            CountryName = countryName;
            Areas = areas;
            Anthem = anthem;
        }

        private int _countryId { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int Areas { get; set; }
        public string Anthem { get; set; }
        public Region region { get; set; }
    
        public static void CreateCountry()
    {

    }

    }
}
