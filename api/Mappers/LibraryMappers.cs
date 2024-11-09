using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Library;
using api.Models;

namespace api.Mappers
{
    public static class LibraryMappers
    {
        public static GetAllDto GetAll(this Library libraryModel)
        {
            return new GetAllDto
            {
                Id = libraryModel.Id,
                Name = libraryModel.Name,
                // Address = libraryModel.Address
            };
        }
        public static GetOneDto GetOne(this Library libraryModel)
        {
            return new GetOneDto
            {
                Id = libraryModel.Id,
                Name = libraryModel.Name,
                Address = libraryModel.Address
            };
        }
        public static Library CreateOne(this CreateDto createDto)
        {
            return new Library
            {
                Name = createDto.Name,
                Address = createDto.Address
            };
        }
    }
}