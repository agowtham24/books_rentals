using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Book;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class BookRepository(AppDbContext context) : IBookRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<Book> CreateBookAsync(Book bookModel)
        {
            await _context.Books.AddAsync(bookModel);
            await _context.SaveChangesAsync();
            return bookModel;
        }

        public async Task<Book?> DeleteBookAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);

            if (book == null)
            {
                return null;
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> GetBookAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> UpdateBookAsync(int id, UpdateBookDto body)
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (book == null)
            {
                return null;
            }

            // Update fields using data from the DTO
            book.Name = body.Name;
            book.Author = body.Author;

            await _context.SaveChangesAsync();
            return book;
        }
    }
}
