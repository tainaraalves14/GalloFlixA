using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("MovieRating")]
public class MovieRating
{
    [Key, Column(Order = 1)]
    public int MovieId { get; set; }
    [ForeignKey("MovieId")]
    public Movie Movie { get; set; } // propriedade de navegação

    [Key, Column(Order = 2)]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public AppUser User { get; set; }

    [Required]
    public byte RatingValue { get; set; }

    [Required]
    public DateTime RatingDate { get; set; } = DateTime.Now;
    
}
