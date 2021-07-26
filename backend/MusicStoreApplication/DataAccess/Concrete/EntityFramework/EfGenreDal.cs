using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGenreDal
        : EfEntityRepositoryBase<Genre, MusicStoreContext>, IGenreDal
    {
        public List<Genre> GetGenreList()
        {
            using (var context = new MusicStoreContext())
            {
                return context.Genres
                    .Include(x => x.AlbumList)
                    .ToList();
            }
        }
    }
}
