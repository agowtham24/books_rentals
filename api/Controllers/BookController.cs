using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController(IBookRepository repository) : ControllerBase
    {
        private readonly IBookRepository _repository = repository;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _repository.GetBooksAsync();
            // System.Console.WriteLine(books);
            _ = books.Select(b => b.GetAll());
            return Ok(books);
        }
    }
}