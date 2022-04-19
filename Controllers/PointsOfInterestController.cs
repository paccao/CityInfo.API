using CityInfo.API.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[Route("api/cities/{cityId}/[controller]")]
[ApiController]
public class PointsOfInterestController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfInterest(int cityId)
    {
        var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.id == cityId);
        if (city == null)
        {
            return NotFound();
        }

        return Ok(city.PointOfInterest);
    }

    [HttpGet("pointofinterestid")]
    public ActionResult<PointOfInterestDto> GetPointOfInterest(int cityId, int pointOfInterestId)
    {
        var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.id == cityId);
        if (city == null)
        {
            return NotFound();
        }

        var pointOfInterest = city.PointOfInterest.FirstOrDefault(c => c.Id == pointOfInterestId);
        if (pointOfInterest == null)
        {
            return NotFound();
        }

        return Ok(pointOfInterest);
    }
}