using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Enums;
using Microsoft.AspNetCore.Http;

namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public int PostId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be between {2} and {1} characters in length.", MinimumLength = 5)]
        public string Content { get; set; }

        public CommentStatus Status { get; set; }

        public virtual BlogUser Author { get; set; }
        public virtual Post Post { get; set; }
        
    }
}
