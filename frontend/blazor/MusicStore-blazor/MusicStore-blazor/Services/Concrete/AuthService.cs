using Microsoft.AspNetCore.Components;
using MusicStore_blazor.Models;
using MusicStore_blazor.Services.Abstract;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Concrete
{
    public class AuthService
        : IAuthService
    {
        private HttpClient _http;

        public AuthService(HttpClient http)
        {
            _http = http;
        }

        public async Task<AccessToken> Login(UserForLoginDto userForLoginDto)
        {
            return await _http.PostJsonAsync<AccessToken>("https://localhost:44369/api/auth/login", userForLoginDto);
        }
    }
}
