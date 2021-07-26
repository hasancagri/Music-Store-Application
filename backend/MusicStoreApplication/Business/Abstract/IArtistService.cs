using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IArtistService
    {
        IDataResult<List<ArtistSelectListForDto>> GetSelectList();
        Artist GetById(int artistId);
    }
}
