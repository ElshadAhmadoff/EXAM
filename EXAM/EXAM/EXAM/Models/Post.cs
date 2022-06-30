using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EXAM.Models
{
    public class Post:BaseEntity
    {
        [Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
        [Required, MaxLength(100)]
        public string Head { get; set; }
        [Required, MaxLength(500)]
        public string Text { get; set; }
        [Required,MaxLength(50)]
        public string ButtonText { get; set; }
    }
}
