namespace CityInfo.API.Controllers.Models;

public class CityDto
{
    public int id { get; set; }

    public string Name { get; set; } = string.Empty;
    
    public string? Description { get; set; }

}