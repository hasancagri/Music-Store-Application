using System.ComponentModel.DataAnnotations;

namespace MusicStore_blazor.Models
{
    public class AlbumUpdateForDto
    {
        public int AlbumId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public int ArtistId { get; set; }
    }
}
