using Moq;
using System.Collections.Generic;
using TestAppWithMoqFramework_v1.Model;
using TestAppWithMoqFramework_v1.Services;
using Xunit;

namespace XUnitTests
{
	/// <summary>
	/// Using Moq framwork to verify tests.
	/// </summary>
	public class UnitTestCountries
	{
		[Fact]
		public void TestCreateBuildingProperties()
		{
			// Create Mock object
			var buildingMock = new Mock<IBuilding>();

			// Test the Name property
			buildingMock.Setup(b => b.Name).Returns("Longtower");

			// Test the Address property
			buildingMock.Setup(b => b.Address).Returns("Longstreet 123 ABCD 5523");

			// Test the BuildCost property
			buildingMock.Setup(b => b.BuildCost).Returns(12232);

			// Test the BuildYear property
			buildingMock.Setup(b => b.BuildYear).Returns(1992);

		}

		[Fact]
		public void TestCreateBuildingMethods()
		{
			// Create Mock object
			var buildingMock = new Mock<IBuilding>();

			// Test the GetName method
			buildingMock.Setup(b => b.GetName()).Returns("Longtower");

			// Test the GetAddress method
			buildingMock.Setup(b => b.GetAddress()).Returns("Longroad 999 ADSC 9981");

			// Test the GetBuildCost method
			buildingMock.Setup(b => b.GetBuildCost()).Returns(123123);

			// Test the GetBuildYear Method
			buildingMock.Setup(b => b.GetBuildYear()).Returns(2004);
		}

		[Fact]
		public void TestCreateCountryPropertiesAndMethods()
		{
			// Create Mock object
			var countrymock = new Mock<ICountry>();

			// Test the Name property
			countrymock.Setup(c => c.Name).Returns("Netherlands");

			// Test the Cities property
			countrymock.Setup(c => c.Cities).Returns(new List<City>());

			// Test the GetName method
			countrymock.Setup(c => c.GetName()).Returns("Netherlands");

			// Test the AddCity method
			countrymock.Setup(c => c.AddCity(It.IsAny<City>())).Returns(true);

			// Test the GetCities method
			countrymock.Setup(c => c.GetCities()).Returns(new List<City>()
			{
				new City
				{
					Name = "Eindhoven",
					Buildings = null
				}
			});
		}

		[Fact]
		public void TestCreateCityPropertiesAndMethods()
		{
			// Create Mock object
			var cityMock = new Mock<ICity>();

			// Test the Name property
			cityMock.Setup(c => c.Name).Returns("Eindhoven");

			// Test the GetName method
			cityMock.Setup(c => c.GetName()).Returns("Geldrop");

			// Test the AddBuilding method
			cityMock.Setup(c => c.AddBuilding(It.IsAny<Building>())).Returns(true);

			// Test the GetBuildings method
			cityMock.Setup(c => c.GetBuildings()).Returns(new List<Building>()
			{
				new Building
				{
					Name = "Big tower",
					Address = "Roadlane 99 ABCD 1239",
					BuildCost = 123123,
					BuildYear = 2005
				}
			});
		}
	}
}
