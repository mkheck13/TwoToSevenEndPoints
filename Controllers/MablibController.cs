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
       [Route("{name}/{city}/{drink}/{weather}")]

       public string Madlib(string name, string city, string drink, string weather)
       {
        return _madService.Madlib(name, city, drink, weather);
       }
    }
