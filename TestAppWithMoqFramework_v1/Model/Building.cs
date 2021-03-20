using TestAppWithMoqFramework_v1.Services;

namespace TestAppWithMoqFramework_v1.Model
{
	public class Building : IBuilding
	{
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Address
		/// </summary>
		public string Address { get; set; }
		
		/// <summary>
		/// Build costs
		/// </summary>
		public int BuildCost { get; set; }

		//Build year
		public int BuildYear { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public Building()
		{
		}

		/// <summary>
		/// Get address
		/// </summary>
		/// <returns></returns>
		public string GetAddress()
		{
			return Address;
		}

		/// <summary>
		/// Get build cost
		/// </summary>
		/// <returns></returns>
		public int GetBuildCost()
		{
			return BuildCost;
		}

		/// <summary>
		/// Get build year
		/// </summary>
		/// <returns></returns>
		public int GetBuildYear()
		{
			return BuildYear;
		}

		/// <summary>
		/// Get name
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			return Name;
		}
	}
}
