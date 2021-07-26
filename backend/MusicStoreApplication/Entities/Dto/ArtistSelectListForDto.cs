using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class ArtistSelectListForDto
        : IDto
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
