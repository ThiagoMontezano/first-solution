using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library;
using Microsoft.AspNetCore.Mvc;

namespace calculator_api.Controllers
{
    [Route("api/calculator")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator calculator;

        public CalculatorController(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        [HttpGet("sum/firstValue/{firstValue}/secondValue/{secondValue}")]
        public ActionResult<float> sum(float firstValue, float secondValue)
        {
            return calculator.sum(firstValue, secondValue);
        }

    }
}
