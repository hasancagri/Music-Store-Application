using System.ComponentModel.DataAnnotations;

namespace MusicStore_blazor.Models
{
    public class AlbumCreateForDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int ArtistId { get; set; }
        [Required]
        public int GenreId { get; set; }
    }
}
