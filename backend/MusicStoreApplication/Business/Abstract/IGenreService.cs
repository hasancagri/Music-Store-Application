using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGenreService
    {
        IDataResult<List<GenreListForDto>> GetList();
        IDataResult<List<GenreSelectListForDto>> GetSelectList();
        Genre GetById(int genreId);
    }
}
