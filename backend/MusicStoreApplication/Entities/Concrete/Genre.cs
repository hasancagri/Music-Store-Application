using Core.Entities.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Genre
        : IEntity
    {
        public Genre()
        {
            AlbumList = new List<Album>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }
        public List<Album> AlbumList { get; set; }
    }
}
