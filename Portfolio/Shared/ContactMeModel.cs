using System.ComponentModel.DataAnnotations;

namespace Portfolio.Shared;

public class ContactMeModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required(ErrorMessage = "Please enter your name: "), StringLength(32), Display(Name = "Name: ")]
    public string? Name { get; set; }

    [Required, StringLength(32), EmailAddress(ErrorMessage = "Please enter a valid email address: ")]
    public string? Email { get; set; }

    [Required, StringLength(32)]
    public string? Subject { get; set; }

    [Required, StringLength(2048), MinLength(100, ErrorMessage = "Minimum length is 100 characters"), MaxLength(2048, ErrorMessage = "Maximum length is 2048 characters")]
    public string? Message { get; set; }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Email)}: {Email}, {nameof(Subject)}: {Subject}, {nameof(Message)}: {Message}";
    }
}
