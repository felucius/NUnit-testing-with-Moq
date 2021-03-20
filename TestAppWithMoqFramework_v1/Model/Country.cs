using System.Collections.Generic;
using TestAppWithMoqFramework_v1.Services;

namespace TestAppWithMoqFramework_v1.Model
{
	public class Country : ICountry
	{
		/// <summary>
		/// Name of the country.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// List of cities.
		/// </summary>
		public List<City> Cities { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public Country()
		{
			Cities = new List<City>();
		}

		/// <summary>
		/// Add a city
		/// </summary>
		/// <param name="city"></param>
		public bool AddCity(City city)
		{
			Cities.Add(city);

			if(Cities.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Retrieve all cities.
		/// </summary>
		/// <returns></returns>
		public List<City> GetCities()
		{
			return Cities;
		}

		/// <summary>
		/// Return the name of the country.
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			return Name;
		}
	}
}
