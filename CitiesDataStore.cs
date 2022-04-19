using CityInfo.API.Controllers.Models;

namespace CityInfo.API;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }

    public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                id = 1,
                Name = "New York City",
                Description = "The one with that big park."
            },
            new CityDto()
            {
                id = 2,
                Name = "Antwerp",
                Description = "The one with the cathedral that was never really finished."
            },

            new CityDto()
            {
                id = 3,
                Name = "Paris",
                Description = "The one with that big tower"
            }
        };
    }
}