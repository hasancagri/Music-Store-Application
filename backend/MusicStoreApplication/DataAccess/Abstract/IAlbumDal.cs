using Core.DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IAlbumDal
        : IEntityRepository<Album>
    {
        List<Album> GetAlbumList();
        List<Album> GetAlbumListByGenreId(int genreId);
        Album GetById(int albumId);
        int GetAlbumCount();
    }
}
