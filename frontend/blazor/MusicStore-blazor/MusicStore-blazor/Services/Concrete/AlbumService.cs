using Microsoft.AspNetCore.Components;
using MusicStore_blazor.Models;
using MusicStore_blazor.Services.Abstract;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore_blazor.Services.Concrete
{
    public class AlbumService
        : IAlbumService
    {
        private HttpClient _http;

        public AlbumService(HttpClient http)
        {
            _http = http;
        }

        public async Task Create(AlbumCreateForDto albumCreateForDto, string token)
        {
            var content = JsonConvert.SerializeObject(albumCreateForDto);
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _http.PostAsync("https://localhost:44369/api/albums/add", new StringContent(content, Encoding.Default, "application/json"));

            //Burada middleware olacak
            if (response.StatusCode != HttpStatusCode.OK)
            {

            }
        }

        public async Task Delete(AlbumDeleteForDto albumDeleteForDto, string token)
        {
            var content = JsonConvert.SerializeObject(albumDeleteForDto);
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _http.PostAsync("https://localhost:44369/api/albums/delete", new StringContent(content, Encoding.Default, "application/json"));

            //Burada middleware olacak
            if (response.StatusCode != HttpStatusCode.OK)
            {
            }
        }

        public async Task<AlbumUpdateForDto> GetById(int albumId, string token)
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return await _http.GetJsonAsync<AlbumUpdateForDto>("https://localhost:44369/api/albums/getbyid?albumId=" + albumId);
        }

        public async Task<AlbumDeleteForDto> GetByIdForDeleting(int albumId, string token)
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return await _http.GetJsonAsync<AlbumDeleteForDto>("https://localhost:44369/api/albums/getbyidfordeleting?albumId=" + albumId);
        }

        public async Task<Album[]> GetList(string token)
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return await _http.GetJsonAsync<Album[]>("https://localhost:44369/api/albums/getlist");
        }

        public async Task<Album[]> GetListByGenreId(int genreId, string token)
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return await _http.GetJsonAsync<Album[]>("https://localhost:44369/api/albums/getlistbygenreid?genreid=" + genreId);
        }


        public async Task Update(AlbumUpdateForDto albumUpdateForDto, string token)
        {
            string content = JsonConvert.SerializeObject(albumUpdateForDto);
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _http.PostAsync("https://localhost:44369/api/albums/update", new StringContent(content, Encoding.Default, "application/json"));

            //Burada middleware olacak
            if (response.StatusCode != HttpStatusCode.OK)
            {
            }
        }
    }
}
