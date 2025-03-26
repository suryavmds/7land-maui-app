namespace SevenLand.Models;

/// <summary>
/// Represents a user (admin/customer) with authentication details.
/// Used for Firebase Auth integration.
/// </summary>
public class User
{
    public string Uid { get; set; } // Firebase Auth ID
    public string Email { get; set; }
    public string DisplayName { get; set; }
    public bool IsAdmin { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string PhoneNumber { get; set; }
}