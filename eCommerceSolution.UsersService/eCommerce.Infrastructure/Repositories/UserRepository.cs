using eCommerce.Core.Dtos;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Domain.Entities;

namespace eCommerce.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public async Task<ApplicationUser?> AddUser(ApplicationUser user)
    {
        // Generate a new unique ID for the user
        user.UserId = Guid.NewGuid();
        return user;
    }

    public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
    {
        return new ApplicationUser()
        {
            UserId = Guid.NewGuid(),
            Email = email,
            Password = password,
            PersonName = "Person Name",
            Gender = nameof(GenderOptions.Male)
        };
    }
}