﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and max {1} characters long.", MinimumLength = 2)]
        public string Text { get; set; }

        public virtual Post Post { get; set; }
        public virtual IdentityUser Author { get; set; }
    }
}