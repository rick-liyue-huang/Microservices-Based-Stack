namespace eCommerce.Domain.Entities;


// Define the ApplicationUser entity with properties for user details and store them in the database.
public class ApplicationUser
{
    public Guid UserId { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? PersonName { get; set; }
    public string? Gender { get; set; }
}