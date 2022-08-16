﻿using System.ComponentModel.DataAnnotations;

namespace TestAPI.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}
