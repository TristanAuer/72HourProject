using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Models.Comment
{
    public class CommentCreate
    {
        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string Text { get; set; }
    }
}
