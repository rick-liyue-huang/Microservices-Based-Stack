using eCommerce.Core.Dtos;

namespace eCommerce.Core.ServiceContracts;


/// <summary>
/// Service contract for user-related operations such as registration and authentication.
/// </summary>
public interface IUserService
{
    /// <summary>
    /// login user with email and password
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<AuthenticationResponse?> Login(LoginRequest request);
    
    /// <summary>
    /// register a new user
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<AuthenticationResponse?> RegisterUser(RegisterRequest request);
}