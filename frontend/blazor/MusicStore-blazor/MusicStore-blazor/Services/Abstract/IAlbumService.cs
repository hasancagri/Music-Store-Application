using MusicStore_blazor.Models;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Abstract
{
    public interface IAlbumService
    {
        Task<Album[]> GetList(string token);
        Task<Album[]> GetListByGenreId(int genreId, string token);
        Task<AlbumUpdateForDto> GetById(int albumId, string token);
        Task<AlbumDeleteForDto> GetByIdForDeleting(int albumId, string token);
        Task Update(AlbumUpdateForDto albumUpdateForDto, string token);
        Task Delete(AlbumDeleteForDto albumDeleteForDto, string token);
        Task Create(AlbumCreateForDto albumCreateForDto, string token);
    }
}
