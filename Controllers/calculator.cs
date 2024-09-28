using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("{x}/{y}")]
    public decimal Add(decimal x, decimal y)
    {
        return x+y;
    }
    public decimal Subtract(decimal x, decimal y)
    {
        return x-y;
    }
    public decimal Multiply(decimal x, decimal y)
    {
        return x*y;
    } 
    public decimal Divide(decimal x, decimal y)
    {
        return x/y;
    }
    public decimal Modulo(decimal x, decimal y)
    {
        return x%y;
    }        
}
