using System;
using System.Collections.Generic;
using System.Text;

namespace Flutters.Database.Models
{
    public class Comment
    {
        public List<Comment> Comments;
        public string PostId { get; set; }
        public string UserId { get; set; }
    }
}
