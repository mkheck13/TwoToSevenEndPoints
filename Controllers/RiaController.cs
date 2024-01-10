using Microsoft.AspNetCore.Mvc;
using TwoToSevenEndPoints.Services.ReverseItAlpha;


namespace TwoToSevenEndPoints.Controllers;

    [ApiController]
    [Route("RevAlpha")]
    public class RiaController : Controller
    {
        private readonly IRiaService _riaServerice;

        public RiaController(IRiaService riaService)
        {
            _riaServerice = riaService;
        }

        [HttpGet]
        [Route("RevAlpha")]

        public string RevAlpha(string alphaInput)
        {
            return _riaServerice.RevAlpha(alphaInput);
        }

    }
