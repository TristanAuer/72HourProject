using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Data
{
    class Like
    {
        [Key]
        public int Id { get; set; }
        // foreign key to post via ID with virtual post
        public Guid OwnerId { get; set; }
    }
}
