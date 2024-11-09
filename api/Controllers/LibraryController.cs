using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Library;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/library")]
    [ApiController]
    public class LibraryController(ILibraryRepository repository) : ControllerBase
    {
        private readonly ILibraryRepository _repository = repository;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var libraries = await _repository.GetLibrariesAsync();

            _ = libraries.Select(l => l.GetAll());

            return Ok(libraries);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var library = await _repository.GetLibraryAsync(id);

            if (library == null)
            {
                return NotFound();
            }

            return Ok(library.GetOne());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDto body)
        {
            var library = body.CreateOne();

            await _repository.CreateLibraryAsync(library);

            return CreatedAtAction(nameof(GetById), new { id = library.Id }, library.GetOne());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateDto body)
        {
            var library = await _repository.UpdateLibraryAsync(id, body);
            if (library == null)
            {
                return NotFound();
            }

            return Ok(library.GetOne());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var library = await _repository.DeleteLibraryAsync(id);

            if (library == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}