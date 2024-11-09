using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Library;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class LibraryRepository(AppDbContext context) : ILibraryRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<Library> CreateLibraryAsync(Library libraryModel)
        {
            await _context.Libraries.AddAsync(libraryModel);
            await _context.SaveChangesAsync();
            return libraryModel;
        }

        public async Task<Library?> DeleteLibraryAsync(int id)
        {
            var library = await _context.Libraries.FirstOrDefaultAsync(x => x.Id == id);

            if (library == null)
            {
                return null;
            }

            _context.Libraries.Remove(library);
            await _context.SaveChangesAsync();
            return library;
        }

        public async Task<List<Library>> GetLibrariesAsync()
        {
            return await _context.Libraries.ToListAsync();
        }

        public async Task<Library?> GetLibraryAsync(int id)
        {
            return await _context.Libraries.FindAsync(id);
        }

        public async Task<Library?> UpdateLibraryAsync(int id, UpdateDto body)
        {
            var library = await _context.Libraries.FirstOrDefaultAsync(x => x.Id == id);
            if (library == null)
            {
                return null;
            }
            library.Address = body.Address;
            library.Name = body.Name;
            await _context.SaveChangesAsync();
            return library;
        }
    }
}