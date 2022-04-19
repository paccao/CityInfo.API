using CityInfo.API.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitiesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<CityDto>> GetCities()
    {
        return Ok(CitiesDataStore.Current.Cities);
    }

    [HttpGet("{id}")]
    public ActionResult<CityDto> GetCity(int id)
    {
        var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(city => city.id == id);

        if (cityToReturn == null)
        {
            return NotFound();
        }

        return Ok(cityToReturn);
    }
}