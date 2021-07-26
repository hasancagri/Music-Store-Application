using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Album
        : IEntity
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}
