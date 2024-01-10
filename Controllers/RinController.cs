using Microsoft.AspNetCore.Mvc;
using TwoToSevenEndPoints.Services.ReverseItNum;

namespace TwoToSevenEndPoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class RinController : Controller
    {
        private readonly IRinService _rinService;

        public RinController(IRinService rinService)
        {
            _rinService = rinService;
        }

        [HttpGet]
        [Route("RevNum")]

        public string RevNum(int numInput)
        {
            return _rinService.RevNum(numInput);
        }
    }
