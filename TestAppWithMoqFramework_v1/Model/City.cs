using System.Collections.Generic;
using TestAppWithMoqFramework_v1.Services;

namespace TestAppWithMoqFramework_v1.Model
{
	public class City : ICity
	{
		/// <summary>
		/// Name of the city
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Buildings
		/// </summary>
		public List<Building> Buildings { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public City()
		{
			Buildings = new List<Building>();
		}

		/// <summary>
		/// Add a building to the list.
		/// </summary>
		/// <param name="building"></param>
		public void AddBuilding(Building building)
		{
			Buildings.Add(building);
		}

		/// <summary>
		/// Retrieve all buildings
		/// </summary>
		/// <returns></returns>
		public List<Building> GetBuildings()
		{
			return Buildings;
		}

		/// <summary>
		/// Return the name of the city.
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			return Name;
		}
	}
}
