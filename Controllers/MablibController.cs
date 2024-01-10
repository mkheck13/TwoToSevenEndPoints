using Microsoft.AspNetCore.Mvc;
using TwoToSevenEndPoints.Services.Madlib;


namespace TwoToSevenEndPoints.Controllers;

    [ApiController]
    [Route("Madlib")]
    public class MadlibController : Controller
    {
       private readonly IMadService _madService;

       public MadlibController(IMadService madService)
       {
        _madService = madService;
       }

       [HttpGet]
       [Route("Madlib")]

       public string Madlib(string day, string city, string drink, string weather)
       {
        return _madService.Madlib(day, city, drink, weather);
       }
    }
