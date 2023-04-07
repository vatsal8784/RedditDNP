using System.ComponentModel.DataAnnotations;

namespace Application.Shared.DTO;

public class RegisterDTO
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public String Password { get; set; }
    
    [Required]
    public String Name { get; set; }

    [Required]
    public String UserName{ get; set; }
    
    public int Age { get; set; }
}