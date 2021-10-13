using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Blog.Models
{
    public class BlogUser : IdentityUser
    {
        [Required]
        [StringLength(150, ErrorMessage = "The {0} must be between {2} and {1} characters in length.", MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "The {0} must be between {2} and {1} characters in length.", MinimumLength = 1)]
        public string LastName { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageType { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
