using Business.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController
        : ControllerBase
    {
        private IAlbumService _albumService;

        public AlbumsController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _albumService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("getlistbygenreid")]
        public IActionResult GetListByGenreId(int genreId)
        {
            var result = _albumService.GetListByGenreId(genreId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int albumId)
        {
            var result = _albumService.GetById(albumId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(AlbumUpdateForDto albumUpdateForDto)
        {
            var result = _albumService.Update(albumUpdateForDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyidfordeleting")]
        public IActionResult GetByIdForDeleting(int albumId)
        {
            var result = _albumService.GetByIdForDeleting(albumId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(AlbumDeleteForDto albumDeleteForDto)
        {
            var result = _albumService.Delete(albumDeleteForDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(AlbumCreateForDto albumCreateForDto)
        {
            var result = _albumService.Create(albumCreateForDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getalbumcount")]
        public IActionResult GetAlbumCount()
        {
            var result = _albumService.GetAlbumCount();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
