using MusicStore_blazor.Models;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Abstract
{
    public interface IAuthService
    {
        Task<AccessToken> Login(UserForLoginDto userForLoginDto);
    }
}
