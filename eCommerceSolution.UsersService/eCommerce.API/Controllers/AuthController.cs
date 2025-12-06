using eCommerce.Core.Dtos;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers;

[Route("api/[controller]")] // api/auth
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }
    
    // Endpoint for user registration
    [HttpPost("register")] // api/auth/register
    public async Task<IActionResult> Register(RegisterRequest? request)
    {
        if (request == null)
        {
            return BadRequest("Invalid user register request data.");
        }
        
        // Call the user service to register the user
        AuthenticationResponse? response = await _userService.RegisterUser(request);
        if (response == null || response.Success == false)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }
    
    // Endpoint for user login
    [HttpPost("login")] // api/auth/login
    public async Task<IActionResult> Login(LoginRequest? request)
    {
        if (request == null)
        {
            return BadRequest("");
        }
        
        AuthenticationResponse? response = await _userService.Login(request);
        if (response == null || response.Success == false)
        {
            return Unauthorized(response);
        }
        return Ok(response);
        
    }
}