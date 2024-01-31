using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers;
[ApiController]
[Route("[controller]")]
public class Calculator : ControllerBase
{
    [HttpGet("Add")]
    public ActionResult<decimal> Add(decimal number1, decimal number2)
    {
        return number1 + number2;
    }
}