using eCommerce.Domain.Entities;

namespace eCommerce.Core.RepositoryContracts;


/// <summary>
/// Contract to be implemented by User Repository
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// create a new user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<ApplicationUser?> AddUser(ApplicationUser user);
    
    /// <summary>
    /// get user by email and password
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
}