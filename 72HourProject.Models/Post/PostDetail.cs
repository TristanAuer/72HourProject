﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourProject.Models.Post
{
    public class PostDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        //[Display(Name="Created")]
        //public DateTimeOffset CreatedUtc { get; set; }
        //[Display(Name = "Modified")]
        //public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
