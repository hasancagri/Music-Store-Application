using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class AlbumUpdateForDto
        : IDto
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
    }
}
