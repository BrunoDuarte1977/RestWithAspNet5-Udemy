using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNetUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstnumber}/{secondnumber}")]
        public IActionResult GetSum(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber)) {
                
                var sun = ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber);
                return Ok(sun);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstnumber}/{secondnumber}")]
        public IActionResult GetSubtraction(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {

                var sun = ConvertToDecimal(firstnumber) - ConvertToDecimal(secondnumber);
                return Ok(sun);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstnumber}/{secondnumber}")]
        public IActionResult GetMultiplication(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {

                var sun = ConvertToDecimal(firstnumber) * ConvertToDecimal(secondnumber);
                return Ok(sun);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstnumber}/{secondnumber}")]
        public IActionResult GetDivision(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {

                var sun = ConvertToDecimal(firstnumber) / ConvertToDecimal(secondnumber);
                return Ok(sun);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("average/{firstnumber}/{secondnumber}")]
        public IActionResult GetAverage(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {

                var sun = (ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber)) / 2;
                return Ok(sun);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("squareroot/{firstnumber}")]
        public IActionResult GetSquareRoot(string firstnumber)
        {
            if (IsNumeric(firstnumber))
            {

                var sun = Math.Sqrt(ConvertToDouble(firstnumber));
                return Ok(sun);
            }

            return BadRequest("Invalid Input");
        }

        private double ConvertToDouble(string strNumer)
        {
            double doubleValue;

            if (double.TryParse(strNumer, out doubleValue))
            {
                return doubleValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumer)
        {
            double number;

            bool isNumer = double.TryParse(
                strNumer,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);

            return isNumer;
        }

        private decimal ConvertToDecimal(string strNumer)
        {
            decimal decimalValue;

            if(decimal.TryParse(strNumer, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}
