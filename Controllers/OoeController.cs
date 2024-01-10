using Microsoft.AspNetCore.Mvc;
using TwoToSevenEndPoints.Services.OddOrEven;


namespace TwoToSevenEndPoints.Controllers;

    [ApiController]
    [Route("OddOrEven")]
    public class OoeController : ControllerBase
    {
        private readonly IOddService _oddService;

        public OoeController(IOddService oddService)
        {
            _oddService = oddService;
        }

        [HttpGet]
        [Route("OddorEven")]

        public string OddOrEven(int num1)
        {
            return _oddService.OddOrEven(num1); 
        }

    }
