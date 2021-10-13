using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        public int AuthorId { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "The {0} must be between {2} and {1} characters in length.", MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be between {2} and {1} characters in length.", MinimumLength = 5)]
        public string Abstract { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }

        public string Slug { get; set; }

        [Display(Name = "Post Image")]
        public byte[] ImageData { get; set; }

        [Display(Name = "Image Type")]
        public string ContentType { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public virtual BlogUser Author { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
