﻿using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class GenreSelectListForDto
         : IDto
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
