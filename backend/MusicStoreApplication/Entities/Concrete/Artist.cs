using Core.Entities.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Artist
        : IEntity
    {
        public Artist()
        {
            AlbumList = new List<Album>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }
        public List<Album> AlbumList { get; set; }
    }
}
