using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class GenreListForDto
        : IDto
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public int AlbumCount { get; set; }
    }
}
