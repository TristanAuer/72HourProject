using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Data
{
    class Reply
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
        // foreign key to comment via ID with virtual comment
    }
}
