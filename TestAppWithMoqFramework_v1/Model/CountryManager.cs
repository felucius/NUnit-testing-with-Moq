using System;
using System.Collections.Generic;

namespace TestAppWithMoqFramework_v1.Model
{
	public class CountryManager
	{
		/// <summary>
		/// Countries
		/// </summary>
		private List<Country> countries;

		/// <summary>
		/// Cities
		/// </summary>
		private List<City> cities;

		/// <summary>
		/// Buildings
		/// </summary>
		private List<Building> buildings;

		/// <summary>
		/// Constructor.
		/// </summary>
		public CountryManager()
		{
			countries = new List<Country>();
			cities = new List<City>();
			buildings = new List<Building>();

			InitializeBuildings();
			InitializeCities();
			InitializeCountries();

			ShowAllCountriesWithInfo();
		}

		/// <summary>
		/// Show all countries and their information.
		/// </summary>
		private void ShowAllCountriesWithInfo()
		{
			foreach(Country country in countries)
			{
				foreach(City city in country.Cities)
				{
					foreach(Building building in city.Buildings)
					{
						Console.WriteLine("Existing countries and their info:");
						Console.WriteLine(string.Format("Country: {0} \nCity: {1}\nBuilding: {2}\nWith info: {3} - {4} - {5}", country.Name, city.Name, building.Name, building.BuildCost, building.Address, building.BuildYear));
					}
				}
			}
		}

		/// <summary>
		/// Initialize countries.
		/// </summary>
		private void InitializeCountries()
		{
			countries.Add(new Country
			{
				Name = "Netherlands",
				Cities = cities
			});
		}

		/// <summary>
		/// Initialize cities.
		/// </summary>
		private void InitializeCities()
		{
			cities.Add(new City
			{
				Name = "Eindhoven",
				Buildings = buildings
			});
		}

		/// <summary>
		/// Initialize buildings.
		/// </summary>
		private void InitializeBuildings()
		{
			buildings.Add(new Building
			{
				Address = "Long road 13 ABCD 5523",
				BuildCost = 123132,
				BuildYear = 1992,
				Name = "Long tower"
			});
		}
	}
}
