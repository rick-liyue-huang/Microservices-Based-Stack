using eCommerce.Core.Dtos;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContracts;
using eCommerce.Domain.Entities;

namespace eCommerce.Core.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<AuthenticationResponse?> Login(LoginRequest request)
    {
        ApplicationUser? user = await _userRepository.GetUserByEmailAndPassword(request.Email, request.Password);
        
        if (user == null)
        {
            return null;
        }

        // Return an AuthenticationResponse with user details and a success status
        return new AuthenticationResponse(
            user.UserId, 
            user.Email, 
            user.PersonName, 
            user.Gender, 
            "token",
            Success: true
        );
    }

    public async Task<AuthenticationResponse?> RegisterUser(RegisterRequest request)
    {
        // Create a new ApplicationUser entity from the RegisterRequest

        ApplicationUser user = new ApplicationUser()
        {
            Email = request.Email,
            Password = request.Password,
            PersonName = request.PersonName,
            Gender = nameof(request.Gender),
        };
        
        ApplicationUser? registeredUser = await _userRepository.AddUser(user);
        
        if (registeredUser == null)
        {
            return null;
        }

        // Return an AuthenticationResponse with user details and a success status
        return new AuthenticationResponse(
            registeredUser.UserId,
            registeredUser.Email,
            registeredUser.PersonName,
            registeredUser.Gender,
            "token",
            Success: true
        );
    }
    
}