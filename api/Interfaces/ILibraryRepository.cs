using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Library;
using api.Models;

namespace api.Interfaces
{
    public interface ILibraryRepository
    {
        Task<List<Library>> GetLibrariesAsync();
        Task<Library?> GetLibraryAsync(int id);
        Task<Library> CreateLibraryAsync(Library libraryModel);
        Task<Library?> UpdateLibraryAsync(int id, UpdateDto updateDto);
        Task<Library?> DeleteLibraryAsync(int id);
    }
}