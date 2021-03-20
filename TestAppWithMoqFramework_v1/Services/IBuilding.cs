
namespace TestAppWithMoqFramework_v1.Services
{
	public interface IBuilding
	{
		// Name
		string Name { get; set; }

		/// <summary>
		/// Address
		/// </summary>
		string Address { get; set; }

		/// <summary>
		/// Build year
		/// </summary>
		int BuildYear { get; set; }

		/// <summary>
		/// Build cost
		/// </summary>
		int BuildCost { get; set; }

		// Get name
		string GetName();

		/// <summary>
		/// Get address
		/// </summary>
		/// <returns></returns>
		string GetAddress();

		/// <summary>
		/// Get build year
		/// </summary>
		/// <returns></returns>
		int GetBuildYear();

		/// <summary>
		/// Get build cost.
		/// </summary>
		/// <returns></returns>
		int GetBuildCost();
	}
}
