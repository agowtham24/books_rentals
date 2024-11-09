using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Book;
using api.Models;

namespace api.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetBooksAsync();
        Task<Book?> GetBookAsync(int id);
        Task<Book> CreateBookAsync(Book bookModel);
        Task<Book?> UpdateBookAsync(int id, UpdateBookDto updateBookDto);
        Task<Book?> DeleteBookAsync(int id);
    }
}