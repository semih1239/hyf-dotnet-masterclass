using Microsoft.AspNetCore.Mvc;
using week3.Models;

namespace week3.Controllers;

[ApiController]
[Route("convert")]

public class ConverterController : ControllerBase
{

    // public List<Distance> CV = new List<Distance>();

    [HttpGet("GallonsToLitres")]
    public double GallonsToLitres(int gallons)
    {
        return gallons * 3.785412;
    }

    [HttpGet("MilesToKilometers")]
    public Distance ConvertMiles(int miles)
    {
        return new Distance()
        {
            Miles = miles,
            Kilometers = (int)(miles * 1.609)
        };
    }

    [HttpPost("ConvertValues")]
    public List<ConversionResponse> ConvertValues([FromBody] ConversionRequest req)
    {
        return new ConversionResponse().Conversion(req);
    }
}