using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "You must enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "You can only enter 100 characters in this field.")]
        public string Title { get; set; }
        [MinLength(1, ErrorMessage = "You have to enter something to post!")]
        [MaxLength(5000)]
        public string Text { get; set; }
    }
}
