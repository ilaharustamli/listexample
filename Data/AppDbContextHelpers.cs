using Core.Data;
using Core.Helper.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class AppDbContextHelpers
{
    static List<Country> countries = new List<Country>();
    static List<Planet> planets = new List<Planet>();

    public static void CreateCountry(Country country)
    {
        countries.Add(country);
    }

        public static void CreateCountry(Country country)
        {
            countries.Add(country);
        }

    public static void CreatePlanet(Planet planet)
    {
        planets.Add(planet);
    }

    public static List<Country> Filter(Region region)
    {
        return countries.FindAll(x => x.region == region);
    }

    public static List<Country> Filter(string countryName)
    {
        return countries.FindAll(x => x.CountryName == countryName);
    }

    public static List<Country> GetAll()
    { return countries; }

    public static Country GetCountryById(int countryId)
    {
        return countries.Find(x => x.CountryId == countryId);
    }


    public static void RemoveCountry(int id)
    {
        Country country = GetCountryById(id);
        countries.Remove(country);
    }
}