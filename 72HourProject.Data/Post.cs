using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Data
{
    class Post
    {   
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        // public virtual list of comments
        // public virtual list of likes
        public Guid AuthorId { get; set; }
    }
}
