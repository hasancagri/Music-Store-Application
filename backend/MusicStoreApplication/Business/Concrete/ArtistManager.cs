using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ArtistManager
        : IArtistService
    {
        private IArtistDal _artistDal;

        public ArtistManager(IArtistDal artistDal)
        {
            _artistDal = artistDal;
        }

        public Artist GetById(int artistId)
        {
            return _artistDal.Get(x => x.ArtistId == artistId);
        }

        public IDataResult<List<ArtistSelectListForDto>> GetSelectList()
        {
            var artistList = _artistDal.GetList();
            var list = artistList.Select(x => new ArtistSelectListForDto
            {
                ArtistId = x.ArtistId,
                Name = x.Name,
            }).ToList();
            return new SuccessDataResult<List<ArtistSelectListForDto>>(list);
        }
    }
}
