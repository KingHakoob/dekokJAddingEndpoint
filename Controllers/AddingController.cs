// Jacob Dekok
// 10/25/2022
// Adding Two Numbers Endpoint
// This program takes the users input from the url bar
// and checks to see if the user inputed numbers
// If so then it will add those two numbers
// Peer Reviewed by: John Magpantay
// notes: Program looks good, Code is executing well. Data validation
// is probably the highlight, Even in API's data validation is still very crucial. Good work overall! 


using Microsoft.AspNetCore.Mvc;

namespace dekokJAddingEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingController : ControllerBase
{
    [HttpGet]
    [Route("Adding/{userNum1}/{userNum2}")]

    public string Adding(string userNum1, string userNum2)
    {
        if(!int.TryParse(userNum1, out int num1)) return "Not Valid Number";
        if(!int.TryParse(userNum2, out int num2)) return "Not Valid Number";
        return Convert.ToString(num1 + num2);
    }
}
