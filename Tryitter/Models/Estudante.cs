namespace Tryitter.Models
{
  using System.ComponentModel.DataAnnotations;
  public class Estudante
  {
    [Key]
    public int EstudanteId { get; set; }
    [Required]
    public string? Nome { get; set; }
    [Required]
    [MaxLength(80)]
    public string? Email { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Modulo { get; set; }
    [Required]
    [MaxLength(80)]
    public string? Status { get; set; }
    [Required]
    [MinLength(8, ErrorMessage = "Senha deve conter pelo menos 8 caracteres")]
    public string? Senha { get; set; }

    public ICollection<Post>? Posts { get; set; } 
  }
}