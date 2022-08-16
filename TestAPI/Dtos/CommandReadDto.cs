using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }

        public string HowTo { get; set; }

        public string Line { get; set; }
    }
}
