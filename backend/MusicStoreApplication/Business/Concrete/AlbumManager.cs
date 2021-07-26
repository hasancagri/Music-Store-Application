using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class AlbumManager
        : IAlbumService
    {
        private IAlbumDal _albumDal;
        private IArtistService _artistService;
        private IGenreService _genreService;

        public AlbumManager(IAlbumDal albumDal, IArtistService artistService, IGenreService genreService)
        {
            _albumDal = albumDal;
            _artistService = artistService;
            _genreService = genreService;
        }

        public IResult Create(AlbumCreateForDto albumCreateForDto)
        {
            var album = new Album
            {
                ArtistId = albumCreateForDto.ArtistId,
                GenreId = albumCreateForDto.GenreId,
                Title = albumCreateForDto.Title,
                Price = albumCreateForDto.Price,
                Artist = _artistService.GetById(albumCreateForDto.ArtistId),
                Genre = _genreService.GetById(albumCreateForDto.GenreId)
            };
            _albumDal.Add(album);

            return new SuccessResult(Messages.AlbumCreated);
        }

        //[SecuredOperation("AlbumDelete")]
        public IResult Delete(AlbumDeleteForDto albumDeleteForDto)
        {
            var album = _albumDal.GetById(albumDeleteForDto.AlbumId);
            _albumDal.Delete(album);

            return new SuccessResult(Messages.AlbumDeleted);
        }

        public IDataResult<int> GetAlbumCount()
        {
            return new SuccessDataResult<int>(_albumDal.GetAlbumCount());
        }

        //[SecuredOperation("GetById")]
        public IDataResult<AlbumUpdateForDto> GetById(int albumId)
        {
            var entity = _albumDal.Get(x => x.AlbumId == albumId);
            var result = new AlbumUpdateForDto
            {
                AlbumId = entity.AlbumId,
                ArtistId = entity.ArtistId,
                GenreId = entity.GenreId,
                Price = entity.Price,
                Title = entity.Title
            };
            return new SuccessDataResult<AlbumUpdateForDto>(result);
        }

        public IDataResult<AlbumDeleteForDto> GetByIdForDeleting(int albumId)
        {
            var entity = _albumDal.GetById(albumId);
            var result = new AlbumDeleteForDto
            {
                AlbumId = entity.AlbumId,
                ArtistName = entity.Artist.Name,
                GenreName = entity.Genre.Name,
                Price = entity.Price,
                Title = entity.Title
            };
            return new SuccessDataResult<AlbumDeleteForDto>(result);
        }

        //[SecuredOperation("AlbumList")]
        public IDataResult<List<AlbumListForDto>> GetList()
        {
            var albumList = _albumDal.GetAlbumList();
            var list = albumList.Select(x => new AlbumListForDto
            {
                AlbumId = x.AlbumId,
                ArtistName = x.Artist.Name,
                GenreName = x.Genre.Name,
                Price = x.Price,
                Title = x.Title
            }).ToList();
            return new SuccessDataResult<List<AlbumListForDto>>(list);
        }

        public IDataResult<List<AlbumListForDto>> GetListByGenreId(int genreId)
        {
            var albumList = _albumDal.GetAlbumListByGenreId(genreId);
            var list = albumList.Select(x => new AlbumListForDto
            {
                AlbumId = x.AlbumId,
                ArtistName = x.Artist.Name,
                GenreName = x.Genre.Name,
                Price = x.Price,
                Title = x.Title
            }).ToList();
            return new SuccessDataResult<List<AlbumListForDto>>(list);
        }

        //[SecuredOperation("AlbumUpdate")]
        public IResult Update(AlbumUpdateForDto albumUpdateForDto)
        {
            var updatedAlbum = _albumDal.GetById(albumUpdateForDto.AlbumId);
            updatedAlbum.ArtistId = albumUpdateForDto.ArtistId;
            updatedAlbum.GenreId = albumUpdateForDto.GenreId;
            updatedAlbum.Title = albumUpdateForDto.Title;
            updatedAlbum.Price = albumUpdateForDto.Price;
            updatedAlbum.Artist = _artistService.GetById(albumUpdateForDto.ArtistId);
            updatedAlbum.Genre = _genreService.GetById(albumUpdateForDto.GenreId);

            _albumDal.Update(updatedAlbum);
            return new SuccessResult(Messages.AlbumUpdated);
        }
    }
}
