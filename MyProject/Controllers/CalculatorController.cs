using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;
namespace MyProject.Controllers;
[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly Calculator _calculator;
    public CalculatorController(Calclculator calculator)
    {
        _calculator = calculator;
    }
    [HttpGet("Add")]
    public ActionResult<decimal> Add(decimal number1, decimal number2)
    {
        return _calculator.Add(number1,number2);
    }
    [HttpGet("Subtract")]
    public ActionResult<decimal> Subtract(decimal number1, decimal number2)
    {
        return _calculator.Subtract(number1,number2);
    }
    [HttpGet("Multiply")]
    public ActionResult<decimal> Multiply(decimal number1, decimal number2)
    {
        return _calculator.Multiply(number1,number2);
    }
    [HttpGet("Divide")]
    public ActionResult<decimal> Divide(decimal number1, decimal number2)
    {
        if(number2==0)
        {
            return BadRequest("Can't divided by zero");
        }
        return _calculator.Divide(number1,number2);
    }
    [HttpGet("Modulo")]
    public ActionResult<decimal> Modulo(decimal number1, decimal number2)
    {
        if(number2==0)
        {
            return BadRequest("Can't find out modulo");
        }
        return _calculator.Modulo(number1,number2);
    }
}