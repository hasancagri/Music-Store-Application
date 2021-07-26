using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class AlbumCreateForDto
        : IDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
    }
}
