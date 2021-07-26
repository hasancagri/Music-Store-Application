using Microsoft.AspNetCore.Components;
using MusicStore_blazor.Models;
using MusicStore_blazor.Services.Abstract;
using System.Net.Http;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Concrete
{
    public class GenreService
        : IGenreService
    {
        private HttpClient _http;

        public GenreService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Genre[]> GetList()
        {
            return await _http.GetJsonAsync<Genre[]>("https://localhost:44369/api/genres/getlist");
        }

        public Task<GenreSelectListForDto[]> GetSelectList()
        {
            return _http.GetJsonAsync<GenreSelectListForDto[]>("https://localhost:44369/api/genres/getselectlist");
        }
    }
}
