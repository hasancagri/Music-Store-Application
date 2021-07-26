﻿using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class AlbumDeleteForDto
        : IDto
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string GenreName { get; set; }
        public string ArtistName { get; set; }
    }
}
