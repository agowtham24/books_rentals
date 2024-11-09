using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Book;
using api.Models;

namespace api.Mappers
{
    public static class BookMappers
    {
        public static GetAllBookDto GetAll(this Book bookModel)
        {
            return new GetAllBookDto
            {
                Id = bookModel.Id,
                Name = bookModel.Name,
                Author = bookModel.Author
            };
        }
        public static GetOneBookDto GetOne(this Book bookModel)
        {
            return new GetOneBookDto
            {
                Id = bookModel.Id,
                Name = bookModel.Name,
                Author = bookModel.Author
            };
        }
        public static Book CreateOne(this CreateBookDto createBookDto)
        {
            return new Book
            {
                Name = createBookDto.Name,
                Author = createBookDto.Author
            };
        }
    }
}