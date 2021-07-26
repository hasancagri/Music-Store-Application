using Core.Utilities.Results;
using Entities.Dto;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAlbumService
    {
        IDataResult<List<AlbumListForDto>> GetList();
        IDataResult<List<AlbumListForDto>> GetListByGenreId(int genreId);
        IDataResult<AlbumUpdateForDto> GetById(int albumId);
        IDataResult<AlbumDeleteForDto> GetByIdForDeleting(int albumId);
        IResult Update(AlbumUpdateForDto albumUpdateForDto);
        IResult Delete(AlbumDeleteForDto albumDeleteForDto);
        IResult Create(AlbumCreateForDto albumCreateForDto);
        IDataResult<int> GetAlbumCount();
    }
}
