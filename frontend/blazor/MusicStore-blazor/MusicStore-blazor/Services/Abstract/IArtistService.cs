using MusicStore_blazor.Models;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Abstract
{
    public interface IArtistService
    {
        Task<ArtistSelectListForDto[]> GetSelectList();
    }
}
