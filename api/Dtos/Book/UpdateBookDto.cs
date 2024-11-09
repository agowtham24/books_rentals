using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Book
{
    public class UpdateBookDto
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}