using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArtistDal
        : EfEntityRepositoryBase<Artist, MusicStoreContext>, IArtistDal
    {
    }
}
