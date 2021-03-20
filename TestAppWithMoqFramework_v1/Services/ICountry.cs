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
		/// Get country name
		/// </summary>
		/// <returns></returns>
		string GetCountry();

		/// <summary>
		/// Get cities.
		/// </summary>
		/// <returns></returns>
		List<City> GetCities();

		/// <summary>
		/// Add a city.
		/// </summary>
		/// <param name="city"></param>
		void AddCity(City city);
	}
}
