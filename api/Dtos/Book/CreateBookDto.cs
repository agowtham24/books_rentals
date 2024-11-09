using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Book
{
    public class CreateBookDto
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}