//-------------------------------------------------------------------------------------------------
//
// ICountry.cs -- The ICountry interface.
//
// Copyright (c) 2021 Marel. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using TestAppWithMoqFramework_v1.Model;

namespace TestAppWithMoqFramework_v1.Services
{
	//---------------------------------------------------------------------------------------------
	/// <summary>
	/// The ICountry interface TODO: Describe interface here
	/// </summary>
	public interface ICountry
	{
		/// <summary>
		/// Name
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Cities
		/// </summary>
		List<City> Cities { get; set; }

		/// <summary>
		/// Get country name
		/// </summary>
		/// <returns></returns>
		string GetName();

		/// <summary>
		/// Get cities.
		/// </summary>
		/// <returns></returns>
		List<City> GetCities();

		/// <summary>
		/// Add a city.
		/// </summary>
		/// <param name="city"></param>
		bool AddCity(City city);
	}
}
