using Microsoft.AspNetCore.Components;
using MusicStore_blazor.Models;
using MusicStore_blazor.Services.Abstract;
using System.Net.Http;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Concrete
{
    public class ArtistService
        : IArtistService
    {
        private HttpClient _http;

        public ArtistService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ArtistSelectListForDto[]> GetSelectList()
        {
            return await _http
                .GetJsonAsync<ArtistSelectListForDto[]>("https://localhost:44369/api/artists/getselectlist");
        }
    }
}
