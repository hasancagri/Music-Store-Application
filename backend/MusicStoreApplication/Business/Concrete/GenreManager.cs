using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class GenreManager
        : IGenreService
    {
        private IGenreDal _genreDal;

        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }

        public Genre GetById(int genreId)
        {
            return _genreDal.Get(x => x.GenreId == genreId);
        }

        public IDataResult<List<GenreListForDto>> GetList()
        {
            var genreList = _genreDal.GetGenreList();
            var list = genreList.Select(x => new GenreListForDto
            {
                GenreId = x.GenreId,
                Name = x.Name,
                AlbumCount = x.AlbumList.Count
            }).ToList();
            return new SuccessDataResult<List<GenreListForDto>>(list);
        }

        public IDataResult<List<GenreSelectListForDto>> GetSelectList()
        {
            var genreList = _genreDal.GetGenreList();
            var list = genreList.Select(x => new GenreSelectListForDto
            {
                GenreId = x.GenreId,
                Name = x.Name,
            }).ToList();
            return new SuccessDataResult<List<GenreSelectListForDto>>(list);
        }
    }
}
