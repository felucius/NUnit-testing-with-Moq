//-------------------------------------------------------------------------------------------------
//
// ICity.cs -- The ICity interface.
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
	/// The ICity interface TODO: Describe interface here
	/// </summary>
	public interface ICity
	{
		/// <summary>
		/// Get city name
		/// </summary>
		/// <returns></returns>
		string GetName();

		/// <summary>
		/// Get buildings.
		/// </summary>
		/// <returns></returns>
		List<Building> GetBuildings();

		/// <summary>
		/// Add building.
		/// </summary>
		/// <param name="building"></param>
		void AddBuilding(Building building);
	}
}
