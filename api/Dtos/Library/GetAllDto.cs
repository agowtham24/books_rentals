using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Library
{
    public class GetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // public string Address { get; set; } = string.Empty;
    }
}