using System.ComponentModel.DataAnnotations;

namespace MudBlazorLearning.Models;

/// <summary>
/// Modello Student - simile a una Entity in Java/JPA
/// </summary>
public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome è obbligatorio")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Nome deve essere tra 2 e 50 caratteri")]
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Cognome è obbligatorio")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Cognome deve essere tra 2 e 50 caratteri")]
    public string LastName { get; set; } = "";

    [Required(ErrorMessage = "Email è obbligatoria")]
    [EmailAddress(ErrorMessage = "Formato email non valido")]
    public string Email { get; set; } = "";

    [Required]
    [Range(16, 100, ErrorMessage = "Età deve essere tra 16 e 100")]
    public int Age { get; set; } = 18;

    [Required(ErrorMessage = "Corso è obbligatorio")]
    public string Course { get; set; } = "";

    public DateTime EnrollmentDate { get; set; } = DateTime.Now;

    public bool IsActive { get; set; } = true;

    // Property computed (simile ai metodi in Java)
    public string FullName => $"{FirstName} {LastName}";
}
