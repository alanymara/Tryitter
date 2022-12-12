namespace Tryitter.Models
{
  using System.ComponentModel.DataAnnotations;
  using System.Text.Json.Serialization;
  public class Post
  {
    [Key]
    public int PostId { get; set; }
    [Required]
    [MaxLength(300)]
    public string? Conteudo { get; set; }
    public int? EstudanteId { get; set; }
    [JsonIgnore]
    public Estudante? Estudante { get; set; } 
  }
}