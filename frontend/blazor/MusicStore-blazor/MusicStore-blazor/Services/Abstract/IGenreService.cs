using MusicStore_blazor.Models;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Abstract
{
    public interface IGenreService
    {
        Task<Genre[]> GetList();
        Task<GenreSelectListForDto[]> GetSelectList();
    }
}
