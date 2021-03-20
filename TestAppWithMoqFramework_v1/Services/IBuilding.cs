
namespace TestAppWithMoqFramework_v1.Services
{
	public interface IBuilding
	{
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
