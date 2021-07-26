using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAlbumDal
        : EfEntityRepositoryBase<Album, MusicStoreContext>, IAlbumDal
    {
        public int GetAlbumCount()
        {
            using (var context = new MusicStoreContext())
            {
                return context.Albums.Count();
            }
        }

        public List<Album> GetAlbumList()
        {
            using (var context = new MusicStoreContext())
            {
                return context.Albums
                    .Include(x => x.Genre)
                    .Include(x => x.Artist)
                    .ToList();
            }
        }

        public List<Album> GetAlbumListByGenreId(int genreId)
        {
            using (var context = new MusicStoreContext())
            {
                return context.Albums
                    .Include(x => x.Genre)
                    .Include(x => x.Artist)
                    .Where(x => x.GenreId == genreId)
                    .ToList();
            }
        }

        public Album GetById(int albumId)
        {
            using (var context = new MusicStoreContext())
            {
                return context.Albums
                    .Include(x => x.Genre)
                    .Include(x => x.Artist)
                    .FirstOrDefault(x => x.AlbumId == albumId);
            }
        }
    }
}
